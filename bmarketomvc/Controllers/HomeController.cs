using Microsoft.AspNetCore.Mvc;

namespace bmarketomvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
