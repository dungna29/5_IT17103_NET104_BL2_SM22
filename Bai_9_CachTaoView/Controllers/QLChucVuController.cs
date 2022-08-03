using System;
using System.Linq;
using Bai_9_CachTaoView.Services;
using EFCORE_DBFIRST_LIBRARY.DomainClass;
using Microsoft.AspNetCore.Mvc;

namespace Bai_9_CachTaoView.Controllers
{
    public class QLChucVuController : Controller
    {
        private IQLChucVuService iQLChucVuService;

        public QLChucVuController()
        {
            iQLChucVuService = new QLChucVuService();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(iQLChucVuService.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ChucVu cv)
        {
            if (cv != null)
            {
                iQLChucVuService.Create(cv);
                return RedirectToAction("Index", "QLChucVu");
            }

            return RedirectToAction("Create", "QLChucVu");
        }

        [HttpGet]
        public IActionResult Update(Guid Id)
        {
            return View(iQLChucVuService.GetAll().FirstOrDefault(c => c.Id == Id));
        }

        [HttpPost]
        public IActionResult Update(ChucVu cv)
        {
            if (cv != null)
            {
                iQLChucVuService.Update(cv);
                return RedirectToAction("Index", "QLChucVu");
            }

            return RedirectToAction("Create", "QLChucVu");
        }

        [HttpGet]
        public IActionResult Delete(Guid Id)
        {
            return View(iQLChucVuService.GetAll().FirstOrDefault(c => c.Id == Id));
        }

        [HttpPost]
        public IActionResult Delete(ChucVu cv)
        {
            if (cv != null)
            {
                iQLChucVuService.Delete(cv);
                return RedirectToAction("Index", "QLChucVu");
            }

            return RedirectToAction("Create", "QLChucVu");
        }

        [HttpGet]
        public IActionResult Detail(Guid Id)
        {
            return View(iQLChucVuService.GetAll().FirstOrDefault(c => c.Id == Id));
        }
    }
}