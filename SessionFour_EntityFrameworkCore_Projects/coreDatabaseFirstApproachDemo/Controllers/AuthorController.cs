using coreDatabaseFirstApproachDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreCodeFirstApproachDemo.Controllers
{
    public class AuthorController : Controller
    {
        ApplicationDBContext context = new ApplicationDBContext();
        public IActionResult Index()
        {
            var authorList = context.Authors.ToList();
            return View(authorList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Author author)
        {
            context.Authors.Add(author);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var author = context.Authors.Find(id);
            if(author == null)
                return RedirectToAction("Index");
            return View(author);
        }

        public IActionResult Delete(int id)
        {
            var author = context.Authors.Find(id);
            if (author == null)
                return RedirectToAction("Index");
            return View(author);
        }

        [HttpPost]
        public IActionResult Delete(Author author)
        {
            context.Authors.Remove(author);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
