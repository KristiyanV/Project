using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BgAuto.Controllers
{
    public class Contact : Controller
    {
        public IActionResult Contacts()
        {
            return View();
        }
    }
}
