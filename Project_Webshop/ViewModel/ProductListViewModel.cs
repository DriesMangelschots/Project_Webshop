using Project_Webshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Webshop.Viewmodel
{
    public class ProductListViewModel
    {
        public string ProductInSearchBar { get; set; }
        public List<Product> Producten { get; set; }
    }
}
