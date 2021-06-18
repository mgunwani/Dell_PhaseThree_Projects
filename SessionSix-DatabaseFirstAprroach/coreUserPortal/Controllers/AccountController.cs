using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreUserPortal.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if(username != null && password != null)
            {
                if(username.Equals("admin") && password.Equals("admin"))
                {
                    return View("Success");
                }
                else
                {
                    ViewBag.ErrorMessage = "Invalid Credentials. Please Try Again";
                    return View("Index");
                }
            }
            else
            {
                ViewBag.ErrorMessage = "Please Enter Credentials";
                return View("Index");
            }
        }
    }
}
