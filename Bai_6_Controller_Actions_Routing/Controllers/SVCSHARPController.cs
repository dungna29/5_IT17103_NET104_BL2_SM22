using Microsoft.AspNetCore.Mvc;

namespace Bai_6_Controller_Actions_Routing.Controllers
{
    //[Route("[controller]/[action]")]
    //[Route("[controller]")]
    //Nếu không muốn khai báo giao-vien trên từng Action thì có thể khai báo lên trước Controller
    [Route("sv-c1")]
    public class SVCSHARPController : Controller
    {
        [Route("")]//Nếu trong trường hợp url rỗng thì sẽ vào action dưới dây
        [Route("trangchu")]// http://localhost:10288/SVCSHARP/trangchu với cách [Route("[controller]")]
        [Route("trangchu")]// http://localhost:10288/sv-c1/trangchu với cách  [Route("sv-c1")]
        public IActionResult Index()
        {
            ViewBag.Mess = "Xin chào đây là trang chủ của sinh viên học Csharp";
            return View();
        }
    }
}