using System.Reflection.Metadata;
using Bai_7_Actions.DomainClass;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace Bai_7_Actions.Controllers
{
    [Route("sinhvienar")]
    public class SinhVienActionResultsController : Controller
    {
        //IActionResult coi như là cha to nhất bên trong có rất nhiều phương thức của các con
        [Route("")]
        [Route("index1")]
        public IActionResult Index(int id)
        {
            if (id == 0) return NotFound();
            return Content("Hello NET104");
        }

        //2 Cách đều cho ra cùng 1 kết quả
        [Route("index2")]
        public ContentResult Index2()
        {
            ContentResult result = new ContentResult();
            result.Content = "Hello Net104";
            return result;
        }

        #region Các loại Action Result

        //1. Trả về HTMl - Có 2 Action result trả về HTML Response. ViewResult và PartialViewResult.
        public IActionResult ViewResult()
        {
            //Phương thức View() tìm kiếm View trong thư mục Views/<Controller> để tìm file .cshtml và chuyển nó cho Razor View Engine. Bạn có thể gán cho nó model dữ liệu. View sẽ trả về một ViewResult và kết quả là một HTML Response.
            var model = new SinhVien();
            return View(model);
        }

        public ActionResult PartialViewResult()
        {
            //PartialView Result sử dụng model để tạo ra một phần của View. Chúng ta sử dụng ViewResult để tạo ra một view hoàn chỉnh còn PartialView trả về một phần của View. Kiểu trả về này hữu ích với Single Page Application (SPA) khi bạn muốn cập nhật một phần của View thông qua AJAX.
            var model = new SinhVien();
            return PartialView(model);
        }

        //Chuyển hướng người dùng(Redriect ): Redriect result được dùng khi bạn muốn chuyển hướng người dùng đến một URL khác. Có 4 loại redirect result có sẵn. RedirectResult, LocalRedirectResult, RedirectToActionResult và RedirectToRouteResult.
        /* Mỗi một redirect này có thể trả về bất cứ mã trạng thái (status code) dưới đây:
         *  302 Found (Chuyển tạp thời)
            301 Moved Permanently
            307 Temporary Redirect
            308 Permanent Redirect
         */

        //http://localhost:25694/sinhvienar/index5
        [Route("index5")]
        public IActionResult RedriectIndex(int id)
        {
            //1. RedirectResult: RedirectResult sẽ trả về cho user bằng cách cung cấp đường dẫn tuyệt đối hoặc tương đối: Thay vào đó, bạn có thể sử dụng RedirectResult trực tiếp được định nghĩa trong Microsoft.AspNetCore.Mvc. Cú pháp là: RedirectResult(string url, bool permanent, bool preserveMethod)
            // Redirect("/sinhvienactionselector/them");
            // RedirectPermanent("/sinhvienactionselector/them");
            // RedirectPermanentPreserveMethod("/sinhvienactionselector/them");
            // RedirectPreserveMethod("/sinhvienactionselector/them");
            // return new RedirectResult(url: "/sinhvienactionselector/them", true, true);

            //2. LocalRedirectResult: Action result này tương tự như RedirectResult nhưng chỉ khác một điều. Chỉ các local URL mới được chấp nhận. Nếu bạn cung cấp bất cứ một URL ngoài nào, phương thức này sẽ trả về một lỗi InvalidOperationException. Điều này tránh việc bị tấn công open redirect attack.
            // LocalRedirect("/sinhvienactionselector/them");
            // LocalRedirectPermanent("/sinhvienactionselector/them");
            // LocalRedirectPermanentPreserveMethod("/sinhvienactionselector/them");
            // return LocalRedirect("/sinhvienactionselector/them");

            //3.RedirectToActionResult: Action result này chuyển client đến một action và controller cụ thể. Nó nhận một tên Action method, một tên controller và các giá trị tham số:

            //Redirects to them action in SinhVienActionSelector
            //return RedirectToAction(actionName: "them", controllerName: "SinhVienActionSelector");

            //Redirects to Index action in the current Controller
            //RedirectToAction(actionName: "Index");

            //4.RedirectToRouteResult: Action result này chuyển khách hàng đến một route cụ thể. Nó nhận tên route, giá trị của route và chuyển chúng ta đến vị trí mà route cung cấp:
            // Redirect using route name
            //return RedirectToRoute("default");

            //Redirect using Route Value
            var routeValue = new RouteValueDictionary(new { action = "them", controller = "sinhvienactionselector" });
            return RedirectToRoute(routeValue);
        }

        #endregion Các loại Action Result
    }
}