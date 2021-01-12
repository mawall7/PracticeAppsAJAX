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

       
        [HttpPost]
        public IActionResult OnFormSubmit(string name, int age)
        {
            var customer = new CustomerViewModel{Name = name, Age = age };
            ViewData["submit"] = "yes";
            return View("_CustomerDetails", customer);
        }

    }
}
