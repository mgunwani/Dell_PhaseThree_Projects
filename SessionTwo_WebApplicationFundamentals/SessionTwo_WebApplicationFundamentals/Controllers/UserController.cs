using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SessionTwo_WebApplicationFundamentals.Models;

namespace SessionTwo_WebApplicationFundamentals.Controllers
{
    public class UserController : Controller
    {

        IList<User> userList = new List<User>()
        {
            new User(){Id=1001, Name="King Kochhar", Age=23},
            new User(){Id=1002, Name="John Smith", Age=56},
            new User(){Id=1003, Name="Sarah Bowling", Age=45},
            new User(){Id=1004, Name="Roger Lee", Age=43},
            new User(){Id=1005, Name="Willim Nick", Age=21},
        };

        public ViewResult Index()
        {
            ViewBag.Message = "Index Page";
            ViewBag.DateTime = DateTime.Now;
            ViewBag.TotalUsers = userList.Count();
            ViewBag.UserList = userList;
            return View();
        }

        public ViewResult About()
        {
            ViewData["Message"] = "About Page";
            ViewData["DateTime"] = DateTime.Now.ToString();
            ViewData["TotalUsers"] = userList.Count();
            ViewData["UserList"] = userList;
            return View();
        }
        public ViewResult Contact()
        {
            TempData["Message"] = "Hello Everyone";
            return View();
        }
        public ViewResult ContactOne()
        {
            String message ="None";
            if (TempData.ContainsKey("Message"))
            {
                message = TempData["Message"].ToString();
            }
            ViewBag.NewMessage = message;
            return View();
        }

        // ModelBinding
        public ViewResult GetUsers()
        {
            return View(userList);
        }

    }
}