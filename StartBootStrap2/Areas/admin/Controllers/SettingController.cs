using Microsoft.AspNetCore.Mvc;
using StartBootStrap2.Data;
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
    }
}
