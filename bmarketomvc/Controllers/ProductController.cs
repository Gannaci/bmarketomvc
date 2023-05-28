using Microsoft.AspNetCore.Mvc;

namespace bmarketomvc.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
