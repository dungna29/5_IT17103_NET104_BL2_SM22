using Microsoft.AspNetCore.Mvc;

namespace Bai_7_Actions.Controllers
{
    public class SinhVienActionSelectorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /*
         * Url Gốc: http://localhost:25694/sinhvienactionselector/add
         * Url Edit: http://localhost:25694/sinhvienactionselector/them
         */

        //C1: ActionName - Khi sử dụng AcctionName sẽ làm thay đổi tên view và phải edit lại tên của view
        [ActionName("them")]
        public IActionResult Add()
        {
            ViewBag.Mess = "Xin chào đây là chức năng thêm sinh viên";
            return View("Add");//Còn nếu không muốn thay thế view mới thì phải return về đúng view đã đổi và có thể , để truyền giá trị trả về
        }

        public IActionResult Update()
        {
            return View();
        }

        [NonAction]
        public string DeleteSV()
        {
            return "Action Method DeleteSV";
        }
    }
}