using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Webshop.Models
{
    public class Orderline
    {
        public int OrderlineID { get; set; }
        public decimal Price { get; set; }
        public decimal Amount  { get; set; }

        public Order Order { get; set; }

        public Product Product { get; set; }

    }
}
