using System;
using Bai_4_MVCWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bai_4_MVCWebApp.Controllers
{
    public class FpolyNET104Controller : Controller
    {
        //Mỗi một Controller sẽ có 1 tên thư mục trong Views và sẽ không chưa từ Controller ở phía sau
        //Mỗi một cái Action Method sẽ đi với 1 file có đuổi .cshtml tương ứng với 1 view
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewSV()
        {
            //Trả lại đối tượng từ Controller ra view
            SinhVienNet104 sv = new SinhVienNet104()
            {
                Id = Guid.NewGuid(),
                Msv = "Ph1234",
                Name = "Dũng"
            };
            return View(sv);
        }
    }
}