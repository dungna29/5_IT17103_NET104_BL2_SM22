using System;
using System.Collections.Generic;
using System.Text;

namespace EFCORE_CODEFIRST_FLUENT_API.DomainClass
{
    public class Category
    {
        public int Id { set; get; }
        public int SortOrder { set; get; }
        public bool IsShowOnHome { set; get; }
        public int? ParentId { set; get; }

        public List<CategoryProduct> CategoryProducts { get; set; }
    }
}