using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApp.Models;
namespace MVCApp.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            
            List<Customer> Customers = new List<Customer>() {
           new Customer() { Id = 1, Name = "Emmanuel nUNO" },
           new Customer() { Id = 2, Name = "Jose nUNO" },
           new Customer() { Id = 3, Name = "Melany nUNO" }

        };
            return View(Customers);
        }
    }
}