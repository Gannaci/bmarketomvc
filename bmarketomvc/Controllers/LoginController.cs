using bmarketomvc.Helpers.Services;
using bmarketomvc.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace bmarketomvc.Controllers
{
    public class LoginController : Controller
    {

        private readonly AuthenticationService _authenticationService;

        public LoginController(AuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                if (await _authenticationService.LoginAsync(viewModel))
                    return RedirectToAction("Index" , "Home");


                ModelState.AddModelError("", "Incorrect Email or Password");
            }

            return View(viewModel);
        }
    }
}
