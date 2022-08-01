using System;
using System.Linq;
using Bai_8_View.Context;
using Bai_8_View.DomainClass;
using Microsoft.AspNetCore.Mvc;

namespace Bai_8_View.Controllers
{
    public class ChucVusController : Controller
    {
        private static FpolyDBContext _dbContext;

        public ChucVusController()
        {
            _dbContext = new FpolyDBContext();
        }

        public IActionResult Index()
        {
            return View(_dbContext.ChucVus.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ChucVu cv)
        {
            _dbContext.Add(cv);
            _dbContext.SaveChanges();
            return RedirectToAction("Index", "ChucVus");
        }

        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            return View(_dbContext.ChucVus.ToList().FirstOrDefault(c => c.Id == id));
        }

        [HttpPost]
        public IActionResult Edit(ChucVu cv)
        {
            _dbContext.Update(cv);
            _dbContext.SaveChanges();
            return RedirectToAction("Index", "ChucVus");
        }

        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            return View(_dbContext.ChucVus.ToList().FirstOrDefault(c => c.Id == id));
        }

        [HttpPost]
        public IActionResult Delete(ChucVu cv)
        {
            _dbContext.Remove(cv);
            _dbContext.SaveChanges();
            return RedirectToAction("Index", "ChucVus");
        }
    }
}