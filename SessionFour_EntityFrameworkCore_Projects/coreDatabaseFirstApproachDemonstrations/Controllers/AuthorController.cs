using coreDatabaseFirstApproachDemonstrations.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreDatabaseFirstApproachDemonstrations.Controllers
{
    public class AuthorController : Controller
    {
        static IList<Author> authorList = new List<Author>()
        {
            new Author(){AuthorId=101, AuthorName="Ratna" , AuthorAge=23},
            new Author(){AuthorId=102, AuthorName="Roger" , AuthorAge=33},
            new Author(){AuthorId=103, AuthorName="Sagar" , AuthorAge=40}
        };

        public IActionResult Index()
        {
            ViewBag.Authors = authorList;
            return View();
        }


        public IActionResult Authors()
        {
            // Model Binding
            return View(authorList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Author author)
        {
            authorList.Add(author);
            return RedirectToAction("Authors");

        }

    }
}
