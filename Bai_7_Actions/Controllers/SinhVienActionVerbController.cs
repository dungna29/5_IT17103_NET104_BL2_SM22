using System;
using System.Collections.Generic;
using System.Dynamic;
using Bai_7_Actions.DomainClass;
using Bai_7_Actions.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bai_7_Actions.Controllers
{
    [Route("sinhvienav")]
    public class SinhVienActionVerbController : Controller
    {
        //HttpGet attribute giới hạn Action method chỉ cấp nhận các request sử dụng GET verb. Các tham số trên URL (query string) tự động được thêm vào như các tham số. HttpGet được dùng để nhận một resource từ server.
        //Tóm lại các Action lấy dữ liệu về thì sử dụng HttpGet
        //Cách 1: Sử dụng ViewData đổ dữ liệu lên view
        [Route("getall1")]
        [HttpGet]
        public IActionResult IndexViewData()
        {
            ViewBag.Message = "Chào các bạn đây là cách lấy danh sách 2 list đối tượng đổ ra thông qua ViewData!";
            ViewData["GiangViens"] = GiangVien.GetAll();
            ViewData["SinhViens"] = SinhVien.GetAll();
            return View();
        }

        //Cách 2: Sử dụng ViewBag đổ dữ liệu lên view
        [Route("getall2")]
        [HttpGet]
        public IActionResult IndexViewBag()
        {
            ViewBag.Message = "Chào các bạn đây là cách lấy danh sách 2 list đối tượng đổ ra thông qua ViewBag!";
            ViewBag.GiangViens = GiangVien.GetAll();
            ViewBag.SinhViens = SinhVien.GetAll();
            return View();
        }

        //Cách 3: Sử dụng dynamic model đổ dữ liệu lên view
        [Route("getall3")]
        [HttpGet]
        public IActionResult IndexDynamicModel()
        {
            ViewBag.Message = "Chào các bạn đây là cách lấy danh sách 2 list đối tượng đổ ra thông qua Dynamic Model!";
            dynamic mymodel = new ExpandoObject();
            mymodel.GiangViens = GiangVien.GetAll();
            mymodel.SinhViens = SinhVien.GetAll();
            return View(mymodel);
        }

        //Cách 4: Sử dụng Tuple  đổ dữ liệu lên view - Lưu ý List không phải là static nếu không sẽ lỗi
        [Route("getall4")]
        [HttpGet]
        public IActionResult IndexTuple()
        {
            GiangVien gv1 = new GiangVien();
            SinhVien sv1 = new SinhVien();
            ViewBag.Message = "Chào các bạn đây là cách lấy danh sách 2 list đối tượng đổ ra thông qua Tuple!";
            var tupleModel = new Tuple<List<GiangVien>, List<SinhVien>>(gv1.GetAll1(), sv1.GetAll1());
            return View(tupleModel);
        }

        [Route("create")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //HttpPost attribute giới hạn action method chấp nhận HTTP Request sử dụng Post verb. Post verb được dùng để tạo mới bản ghi.
        //Tóm lại khi tạo mới cập nhật tác động vào DB chúng at sẽ dung HttpPost
        [Route("create")]
        [HttpPost]
        public IActionResult Create(SinhVien model)
        {
            string message = string.Empty;
            if (ModelState.IsValid)
            {
                message = "Sinh Viên: " + model.Ten + " Thêm mới thành công";
            }
            else
            {
                message = "Thêm thất bại";
            }
            return Content(message);
        }
    }
}