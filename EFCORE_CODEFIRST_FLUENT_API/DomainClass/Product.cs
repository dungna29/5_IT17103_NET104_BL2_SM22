using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace EFCORE_CODEFIRST_FLUENT_API.DomainClass
{
    public class Product
    {
        public int Id { set; get; }
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime DateCreated { set; get; }
        public List<CategoryProduct> CategoryProducts { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}