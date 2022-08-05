using System.Collections.Generic;
using System.Linq;
using BAI_11_ShoppingCart.Models;
using BAI_11_ShoppingCart.Services;
using BAI_11_ShoppingCart.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace BAI_11_ShoppingCart.Controllers
{
    public class CartController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(c => c.Product.Price * c.Quantity);
            return View();
        }
        [NonAction]
        private int isExist(string id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.Id.Equals(id))
                {
                    return i;
                }
            }

            return -1;
        }
        [HttpPost]
        public IActionResult Buy(string id)
        {
            ServiceProduct serviceProduct = new ServiceProduct();
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item { Product = serviceProduct.FindProduct(id), Quantity = 1 });
                SessionHelper.setObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new Item { Product = serviceProduct.FindProduct(id), Quantity = 1 });
                }
                SessionHelper.setObjectAsJson(HttpContext.Session, "cart", cart);
            }

            return RedirectToAction("Index");
        }
        public IActionResult Remove(string id)
        {

            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            int index = isExist(id);
            cart.RemoveAt(index);
            SessionHelper.setObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }

        public IActionResult CheckOut()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(c => c.Quantity * c.Product.Price);
            return View();
        }
    }
}
