using BusinessListing.Model.DTO.Requests;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessListings.Web
{
    public class UserAuthenticationController : Controller
    {
        public IActionResult Login(UserLogin userLogin)
        {
            if (ModelState.IsValid)
            {
                //c
            }
            return View();
        }
    }
}
