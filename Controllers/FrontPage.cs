using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessListings.Controllers
{
    public class FrontPage : Controller
    {
        public IActionResult Index()
        {
            var x = 5;
            return View();
        }
    }
}
