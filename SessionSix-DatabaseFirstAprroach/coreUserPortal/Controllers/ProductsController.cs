using coreUserPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreUserPortal.Controllers
{
    public class ProductsController : Controller
    {
        ProjectDBContext context = new ProjectDBContext();
        public IActionResult Index()
        {
            var products = context.Products
                .Include(p => p.Brand)
                .Include(p => p.Category)
                .ToList();
            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = context.Products.Where(p => p.ProductId == id)
                .Include(p => p.Brand).Include(p => p.Category).SingleOrDefault();
            if (product == null)
                return RedirectToAction("Index");
            return View(product);
        }
    }
}
