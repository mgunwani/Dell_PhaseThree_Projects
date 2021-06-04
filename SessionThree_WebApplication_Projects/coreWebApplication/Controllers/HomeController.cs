using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Title = "Index Page";
            return View();
        }
        public ViewResult About()
        {
            ViewBag.Title = "About Page";
            return View("AboutPage");
        }
    }
}
