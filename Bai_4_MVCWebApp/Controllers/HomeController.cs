using Microsoft.AspNetCore.Mvc;

namespace Bai_4_MVCWebApp.Controllers
{
    public class HomeController : Controller
    {
        //url: home/index đường dẫn tuyệt đối vào ActionMethod
        public string Index()
        {
            return "Xin chào các bạn đây là chuỗi trả ra từ HomeController";
        }
    }
}