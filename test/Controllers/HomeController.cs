using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using test.Models;
using test.Repository;

namespace test.Controllers
{
    public class HomeController : Controller
    {
        Database db = new Database();
        public IActionResult Index()
        {
            
            return View();
        }
        
        public IActionResult List()
        {
            var model=db.getProductList();
            return View(model);
        }
        public IActionResult Add(ProductInventory prod)
        {
            //string name = prod.name;
            //double price = prod.price;
            //int quantity = prod.quantity;
            //string type = prod.type;
            var model = db.getProductList();
            ProductInventory newProd = new ProductInventory();
            newProd.name = prod.name;
            newProd.price = prod.price;
            newProd.quantity = prod.quantity;
            newProd.type = prod.type;
            model.Add(newProd);
            return View();
        }

        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Delete()
        {

            return View();
        }
        

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
