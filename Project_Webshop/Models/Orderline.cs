using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Webshop.Models
{
    public class Orderline
    {
        public int OrderlineID { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        public decimal Price { get; set; }
        public decimal Amount  { get; set; }

  

        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }

    }
}
