using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GC.WEB.Controllers
{
    public class OutageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
