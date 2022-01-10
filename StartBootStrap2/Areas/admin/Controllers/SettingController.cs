using Microsoft.AspNetCore.Mvc;
using StartBootStrap2.Data;
using StartBootStrap2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartBootStrap2.Areas.admin.Controllers
{
    [Area("admin")]
    public class SettingController : Controller
    {
        private readonly AppDbContext _context;

        public SettingController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Settings.FirstOrDefault());
        }

        public IActionResult Update(int id)
        {
            return View(_context.Settings.Find(id));
        }

        [HttpPost]
        public IActionResult Update(Setting model)
        {
            if (ModelState.IsValid)
            {
                _context.Settings.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Model is not Valid!!!");
                return View(model);
            }
        }
    }
}
