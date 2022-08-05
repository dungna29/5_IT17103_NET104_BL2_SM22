using System.Collections.Generic;
using System.Linq;
using BAI_11_ShoppingCart.Models;

namespace BAI_11_ShoppingCart.Services
{
    public class ServiceProduct
    {
        public List<Product> _lstProducts { get; set; }

        public List<Product> FakeDataProducts()
        {
            _lstProducts = new List<Product>
            {
                new Product()
                {
                    Id = "1", Name = "Vàng Poly 1", Photo = "sp1.jpg", Price = 50000
                },
                new Product()
                {
                    Id = "2", Name = "Vàng Poly 2", Photo = "sp1.jpg", Price = 60000
                },
                new Product()
                {
                    Id = "3", Name = "Vàng Poly 3", Photo = "sp1.jpg", Price = 70000
                },
                new Product()
                {
                    Id = "4", Name = "Vàng Poly 4", Photo = "sp1.jpg", Price = 80000
                },
                new Product()
                {
                    Id = "5", Name = "Vàng Poly 5", Photo = "sp1.jpg", Price = 90000
                },
                new Product()
                {
                    Id = "6", Name = "Vàng Poly 6", Photo = "sp1.jpg", Price = 100000
                }
            };
            return _lstProducts;
        }

        public Product FindProduct(string id)
        {
            return FakeDataProducts().Where(c => c.Id == id).FirstOrDefault();
        }
    }
}
