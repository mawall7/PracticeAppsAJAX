using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomersAJAX.Models
{
    public class Customer
    {
       

        

        public string Name { get; set; }

        public int Age { get; set; }

        public List<Customer> customers { get; set; }
        public Customer(string name, int age)
        {
        
            Name = name;
            Age = age;
        }
    }
}
