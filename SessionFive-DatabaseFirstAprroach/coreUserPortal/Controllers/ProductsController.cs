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
    }
}
