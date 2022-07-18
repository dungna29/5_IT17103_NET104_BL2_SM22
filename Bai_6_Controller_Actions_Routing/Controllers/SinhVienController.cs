using Microsoft.AspNetCore.Mvc;

namespace Bai_6_Controller_Actions_Routing.Controllers
{
    //[Route("[controller]")]
    public class SinhVienController : Controller
    {
        /*
         * URL: http://localhost:10288/sinh-vien
         * URL: http://localhost:10288/sinh-vien/trangchu
         *
         */

        [Route("sinh-vien")]
        [Route("sinh-vien/trangchu")]
        public IActionResult Index()
        {
            ViewBag.Mess = "Xin chào đây là trang chủ của sinh viên";
            return View();
        }

        /*
         * URL: http://localhost:10288/sinh-vien/themsv
         * URL: http://localhost:10288/sinh-vien/themsv/1
         */

        [Route("sinh-vien/themsv/{id:int?}")]//Thêm ? có nghĩa tham số có thể null
        public IActionResult Add(int id)
        {
            ViewBag.So = id;
            return View();
        }

        [Route("")]//Nếu trong trường hợp url rỗng thì sẽ vào action dưới dây
        [Route("/sinh-vien/HandleError/{code:int?}")]
        public IActionResult HandleError(int code)
        {
            ViewData["Mess"] = $"Toang rồi bạn ơi. The ErrorCode is: {code}";
            return View("~/Views/SinhVien/HandleError.cshtml");
        }
    }
}