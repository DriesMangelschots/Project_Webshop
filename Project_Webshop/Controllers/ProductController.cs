using Microsoft.AspNetCore.Mvc;
using Project_Webshop.Models;
using Project_Webshop.Viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Webshop.Controllers
{
    public class ProductController : Controller
    {
        public List<Product> productSweater;
        public List<Product> productTshirt;
        public List<Product> mug;
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Tshirt()
        {
            ProductListViewModel viewModel = new ProductListViewModel();
            viewModel.Producten = productTshirt;
            return View(viewModel);
        }
        public IActionResult Mug()
        {
            ProductListViewModel viewModel = new ProductListViewModel();
            viewModel.Producten = mug;
            return View(viewModel);
        }
        public IActionResult Sweater()
        {
            ProductListViewModel viewModel = new ProductListViewModel();
            viewModel.Producten = productSweater;
            return View(viewModel);
        }
        public ProductController()
        {
            productSweater = new List<Product>();
            productSweater.Add(new Product() { Color = "Black", Price = 25, Discount = true, Favorite = false, Quantity = 1, Size = "M", ProductID = 1 });
            productSweater.Add(new Product() { Color = "Lemon", Price = 35, Discount = false, Favorite = false, Quantity = 2, Size = "S", ProductID = 2 });
            productSweater.Add(new Product() { Color = "Purple", Price = 35, Discount = false, Favorite = false, Quantity = 5, Size = "XL", ProductID = 3 });
            productSweater.Add(new Product() { Color = "Royal Blue", Price = 25, Discount = true, Favorite = false, Quantity = 3, Size = "L", ProductID = 4 });
            productSweater.Add(new Product() { Color = "Slate Red", Price = 35, Discount = false, Favorite = false, Quantity = 1, Size = "M", ProductID = 5 });




            productTshirt = new List<Product>();
            productTshirt.Add(new Product() { Color = "Black", Price = 15, Discount = true, Favorite = false, Quantity = 4, Size = "M", ProductID = 6 });
            productSweater.Add(new Product() { Color = "Lemon", Price = 35, Discount = false, Favorite = false, Quantity = 2, Size = "S", ProductID = 7 });
            productSweater.Add(new Product() { Color = "Purple", Price = 35, Discount = false, Favorite = false, Quantity = 5, Size = "L", ProductID = 8 });
            productSweater.Add(new Product() { Color = "Royal Blue", Price = 25, Discount = false, Favorite = false, Quantity = 5, Size = "M", ProductID = 9 });
            productSweater.Add(new Product() { Color = "Slate Red", Price = 35, Discount = false, Favorite = false, Quantity = 1, Size = "XXL", ProductID = 10 });


            mug = new List<Product>();
            productSweater.Add(new Product() { Color = "White", Price = 15, Discount = false, Favorite = false, Quantity = 10, Size = "", ProductID = 11 });
            productSweater.Add(new Product() { Color = "White", Price = 20, Discount = false, Favorite = false, Quantity = 15, Size = "", ProductID = 12 });
         

        }
    }
}
