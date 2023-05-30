using Microsoft.AspNetCore.Mvc;

namespace bmarketomvc.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int productId)
        {
            return View(productId);
        }
    }
}
