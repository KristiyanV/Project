using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BgAuto.Controllers
{
    public class ForUs : Controller
    {
        public IActionResult ForUsPage()
        {
            return View();
        }
    }
}
