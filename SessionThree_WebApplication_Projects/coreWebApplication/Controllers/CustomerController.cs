using coreWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreWebApplication.Controllers
{
    public class CustomerController : Controller
    {
        IList<Customer> customerList = new List<Customer>() {
            new Customer() { Id=1, Name="King", Amount=12000},
            new Customer() { Id=2, Name="Kochhar", Amount=22000},
            new Customer() { Id=3, Name="Shreya", Amount=32000},
            new Customer() { Id=4, Name="Gautam", Amount=40000},
            new Customer() { Id=5, Name="Kartik", Amount=22000}
        };
        
        public ViewResult Index()
        {
            ViewBag.message = "Customer Management System";
            ViewBag.customers = customerList;
            return View();
        }
    }
}
