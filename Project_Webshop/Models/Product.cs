using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Webshop.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public bool Discount { get; set; }
        public bool Favorite { get; set; }
        Orderline Orderline { get; set; }

        public virtual ICollection<Orderline> Orderlines { get; set; }

    }
}
