﻿using ClothBazar.Entities;
using ClothBazar.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothBazar.Controllers
{
    public class ProductController : Controller
    {
        ProductService productService = new ProductService();
        // GET: Product
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult ProductTable(string search)
        {
            var products = productService.GetProducts();
            if (string.IsNullOrEmpty(search) == false)
            {
                products = products.Where(p => p.Name!=null&&p.Name.ToLower().Contains(search.ToLower())).ToList();
            }

            return PartialView(products);
        }
        [HttpGet]
        public ActionResult Create()
        {

            return PartialView();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            productService.SaveProduct(product);


            return RedirectToAction("ProductTable");
        }
    }
}