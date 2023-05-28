﻿using bmarketomvc.Helpers.Services;
using bmarketomvc.Models.Entities;
using bmarketomvc.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bmarketomvc.Controllers
{
    public class RegisterController : Controller
    {

        private readonly UserManager<UserEntity> _userManager;
        private readonly AuthenticationService _authenticationService;

        public RegisterController(UserManager<UserEntity> userManager, AuthenticationService authenticationService)
        {
            _userManager = userManager;
            _authenticationService = authenticationService;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task <IActionResult> Index(RegisterViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                if (!await _userManager.Users.AnyAsync(x => x.Email == viewModel.Email))
                {
                    if (await _authenticationService.RegisterAsync(viewModel))
                    return RedirectToAction("Index", "Login");
                }

                ModelState.AddModelError("", "User witht the same email address already exists");
            }

            return View(viewModel);
        }
    }
}
