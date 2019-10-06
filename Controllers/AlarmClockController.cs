using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoxieMillion.Controllers
{
    public class AlarmClockController : Controller
    {

        public IActionResult Clock()
        {
            return View();
        }

        public IActionResult Destination()
        {
            return View();
        }
    }
}
