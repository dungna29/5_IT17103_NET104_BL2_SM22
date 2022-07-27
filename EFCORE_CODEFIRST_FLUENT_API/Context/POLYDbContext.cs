using System;
using System.Collections.Generic;
using System.Text;
using EFCORE_CODEFIRST_FLUENT_API.Configurations;
using EFCORE_CODEFIRST_FLUENT_API.DomainClass;
using EFCORE_CODEFIRST_FLUENT_API.Extensions;
using Microsoft.EntityFrameworkCore;

namespace EFCORE_CODEFIRST_FLUENT_API.Context
{
    public class POLYDbContext : DbContext
    {
        public POLYDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Khi cấu hình đường dẫn nếu chưa có DB thì tự đặt tên lại DB ở đây
            // optionsBuilder.UseSqlServer("Data Source=DUNGNAPC\\SQLEXPRESS;Initial Catalog=IT17103_FLUENTAPI_NET104;Persist Security Info=True;User ID=dungna34;Password=123456");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryProductlConfiguration());
            //Seeding Data
            modelBuilder.SeedData();//Add-migration sau đó update-database
        }

        //Các bảng
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<CategoryProduct> CategoryProducts { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}