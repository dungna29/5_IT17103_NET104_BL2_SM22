using System;
using System.Collections.Generic;
using System.Text;
using EFCORE_CODEFIRST_FLUENT_API.DomainClass;
using Microsoft.EntityFrameworkCore;

namespace EFCORE_CODEFIRST_FLUENT_API.Extensions
{
    public static class FPOLYExtention
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            //Bắt buộc phải triển khóa chính khi seed
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, IsShowOnHome = true, ParentId = 0, SortOrder = 1 },
                new Category() { Id = 2, IsShowOnHome = true, ParentId = 1, SortOrder = 1 },
                new Category() { Id = 3, IsShowOnHome = true, ParentId = 1, SortOrder = 1 }

            );
            //Muốn thêm bảng thì làm tương tự
            //Thử làm thêm mấy bảng
        }
    }
}