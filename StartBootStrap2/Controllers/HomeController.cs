using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StartBootStrap2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StartBootStrap2.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
