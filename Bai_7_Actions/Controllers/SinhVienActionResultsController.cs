using Microsoft.AspNetCore.Mvc;

namespace Bai_7_Actions.Controllers
{
    [Route("sinhvienar")]
    public class SinhVienActionResultsController : Controller
    {
        //IActionResult coi như là cha to nhất bên trong có rất nhiều phương thức của các con
        public IActionResult Index(int id)
        {
            if (id == 0) return NotFound();
            return Content("Hello NET104");
        }

        //2 Cách đều cho ra cùng 1 kết quả
        public ContentResult Index2()
        {
            ContentResult result = new ContentResult();
            result.Content = "Hello Net104";
            return result;
        }

        #region Các loại Action Result

        //1. Trả về HTMl - Có 2 Action result trả về HTML Response. ViewResult và PartialViewResult.

        #endregion Các loại Action Result
    }
}