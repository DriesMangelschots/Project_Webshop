using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Webshop.Models
{
    public class Orderline
    {
        public int OrderlineID { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public Decimal Price { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public Decimal Amount  { get; set; }

  

        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }

    }
}
