﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Webshop.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Tshirt()
        {
            return View();
        }
        public IActionResult Mug()
        {
            return View();
        }
        public IActionResult Sweater()
        {
            return View();
        }
    }
}
