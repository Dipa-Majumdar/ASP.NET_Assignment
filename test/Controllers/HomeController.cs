﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using test.Models;
using test.Repository;
using test.Services;
using test.ViewModels;

namespace test.Controllers
{
    public class HomeController : Controller
    {
        private IProductData _productData;
        Database db = new Database();
        IProductRepository ipObj = new ProductImp();


        public HomeController(IProductData productData)
        {
            _productData = productData;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            // var model=ipObj.List();
            var model = new HomeIndexViewModel();
            model.Products = _productData.GetAll();
            return View(model);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(ProductEditModel model)
        {
            if (ModelState.IsValid)
            {
                var newProduct = new ProductInventory();
                newProduct.name = model.name;
                newProduct.price = model.price;
                newProduct.quantity = model.quantity;
                newProduct.type = model.type;

                newProduct = _productData.Add(newProduct);
                //return View("Update", newProduct);
                return RedirectToAction(nameof(Update), new { name = newProduct.name });
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult Update(string name)
        {
            var model = _productData.Update(name);
            return View(model);
        }
        [HttpPost]
        public IActionResult Update(ProductEditModel model)
        {
            var newProduct = new ProductInventory();
            newProduct.name = model.name;
            newProduct.price = model.price;
            newProduct.quantity = model.quantity;
            newProduct.type = model.type;
            newProduct = _productData.Add(newProduct);
            return RedirectToAction("Updated");
        }
        public IActionResult Updated(ProductEditModel model)
        {

            return View();
        }
        public IActionResult Delete(ProductEditModel model)
        {
            
            return View();
        }





        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
