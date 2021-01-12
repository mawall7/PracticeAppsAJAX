using CustomersAJAX.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomersAJAX.Controllers
{
    public class CustomerController : Controller
    {


        public CustomerController()
        {


        }
        [HttpGet]
        public IActionResult Customer()
        {
            ViewData["submit"] = "no";
            return View();

        }

        //public IActionResult PartialViewMethod(Customer customer)
        //{
        //    return  PartialView (customer);
        //}

        [HttpPost]
        public IActionResult OnFormSubmit(string name, int age)
        {
            var customer = new Customer(name, age);
            ViewData["submit"] = "yes";
            return View("_CustomerDetails", customer);
        }

    }
}
