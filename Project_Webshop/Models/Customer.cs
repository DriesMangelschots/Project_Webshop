using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Webshop.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Password { get; set; }

        // salt search how this works
        // public string DeliveryAddress { get; set; }
        public Newsletter Newsletter;
        public ICollection<Order>Orders { get; set; }

    }
}
