using System;
using System.Collections.Generic;
using System.Text;
using EFCORE_CODEFIRST_LIBRARY.DomainClass;
using Microsoft.EntityFrameworkCore;

namespace EFCORE_CODEFIRST_LIBRARY.Context
{
    public class FpolyDBContext : DbContext//Phải kế thừa một lớp cha DbContext
    {
        //1. Phải ghi đè lại phương thức OnConfiguring của lớp cha
        //2. Xem lại cách ghi đè 1 phương thức không cần dùng Resharper
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Khi cấu hình đường dẫn nếu chưa có DB thì tự đặt tên lại DB ở đây
            optionsBuilder.UseSqlServer("Data Source=DUNGNAPC\\SQLEXPRESS;Initial Catalog=IT17103_NET104_CODEFIRST;Persist Security Info=True;User ID=dungna34;Password=123456");
        }

        //3. Khai báo các bảng
        public DbSet<Account> Accounts { get; set; }

        public DbSet<Role> Roles { get; set; }
    }
}