using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

namespace WeClean.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult HouseKeeping()
        {
            return View();
        }

        public IActionResult OfficeCleaning()
        {
            return View();
        }

        public IActionResult CarpetCleaning()
        {
            return View();
        }

        public IActionResult TileCleaning()
        {
            return View();
        }

        public IActionResult LaundryService()
        {
            return View();
        }

        public IActionResult WindowCleaning()
        {
            return View();
        }

        public IActionResult Disinfection()
        {
            return View();
        }
    }
}
