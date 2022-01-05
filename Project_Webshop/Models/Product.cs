using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Webshop.Models
{
    public class Product
    {

        public int ProductID { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public Decimal Price { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public Decimal Quantity { get; set; }
        public bool Discount { get; set; }
        public bool Favorite { get; set; }
        //Orderline Orderline { get; set; }

        //public virtual ICollection<Orderline> Orderlines { get; set; }

    }
}
