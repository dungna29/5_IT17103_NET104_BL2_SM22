using Bai_6_Controller_Actions_Routing.Models;
using Bai_6_Controller_Actions_Routing.Services;
using Microsoft.AspNetCore.Mvc;

namespace Bai_6_Controller_Actions_Routing.Controllers
{
    public class GiaoVienController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewGiaoVien()
        {
            ViewData["Key Dungna"] = "Đây là string từ GiaoVien Contronller";//Sử dụng Key là Key Dungna ở bên View gọi ra
            ViewData["GiaoVien"] = new GiaoVien()
            {
                MaGV = "dungna29",
                Ten = "Dũng",
                Email = "Dungna29@fe.edu.vn",
                Image = "/images/img1.jpg"
            };

            ViewBag.DungnaPoly = "Data từ View Bag";
            /*
             * ViewData và ViewBag đều là các tùy chọn hữu ích khi bạn muốn gán lượng dữ liệu nhỏ từ Controller sang View. Điểm yếu là chúng ta ko thể kiểm soát nó trong lúc code nên nó dễ tăng khả năng phát sinh lỗi
               ViewData và ViewBag có thể truyền dữ liệu từ Controller sang View. Nó không thể truyền ngang từ Controller này sang Controller kia được.
             */

            return View();
        }
    }
}