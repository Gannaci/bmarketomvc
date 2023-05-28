using bmarketomvc.Helpers.Repositories;
using bmarketomvc.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace bmarketomvc.Controllers
{
    public class ContactsController : Controller
    {
        private readonly ContactFormRepo _formRepo;
    public ContactsController(ContactFormRepo formRepo)
            {
                _formRepo = formRepo;
            }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> Index(ContactFormViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                await _formRepo.AddAsync(viewModel);
                return RedirectToAction("Index");
            }
            return View(viewModel);
        }
    }
}
