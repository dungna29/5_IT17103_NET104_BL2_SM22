using BAI_11_ShoppingCart.Services;
using Microsoft.AspNetCore.Mvc;

namespace BAI_11_ShoppingCart.Controllers
{
    public class ProductController : Controller
    {
        private ServiceProduct _serviceProduct = new ServiceProduct();

        public IActionResult Index()
        {
            ViewBag.product = _serviceProduct.FakeDataProducts();
            return View();
        }
    }
}
