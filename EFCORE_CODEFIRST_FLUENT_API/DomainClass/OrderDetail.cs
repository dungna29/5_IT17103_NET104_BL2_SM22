using System;
using System.Collections.Generic;
using System.Text;

namespace EFCORE_CODEFIRST_FLUENT_API.DomainClass
{
    public class OrderDetail
    {
        public int OrderId { set; get; }
        public int ProductId { set; get; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }

        public Order Order { get; set; }

        public Product Product { get; set; }
    }
}