using coreDatabaseFirstFundamentals.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreDatabaseFirstFundamentals.Controllers
{
    public class ProductsController : Controller
    {
        ProjectDBContext context = new ProjectDBContext();

        // GET: ProductsController
        public ActionResult Index()
        {
            var products = context.Products
                .Include(p => p.Brand)
                .Include(p => p.Category).ToList();
            return View(products);
        }

        // GET: ProductsController/Details/5
        public ActionResult Details(int id)
        {
            /*var product = context.Products.Find(id);*/
            var product = context.Products.Where(p => p.ProductId == id)
                .Include(p => p.Brand)
                .Include(p => p.Category).FirstOrDefault();
            if (product == null)
                return RedirectToAction("Index");
            return View(product);
        }

        // GET: ProductsController/Create
        public ActionResult Create()
        {
            ViewBag.BrandId = new SelectList(context.Brands, "BrandId", "BrandName");
            ViewBag.CategoryId = new SelectList(context.Categories, "CategoryId", "CategoryName");
            return View();
        }

        // POST: ProductsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
