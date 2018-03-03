using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Models;

namespace test.Services
{
    public class InMemoryProductData : IProductData
    {
        public InMemoryProductData()
        {
            _products = new List<ProductInventory>
                {
                new ProductInventory { name = "lettuce", price = 10.5, quantity = 50, type = "Leafy green" },
                new ProductInventory() { name = "cabbage", price = 20, quantity = 100, type = "Cruciferous" },
                new ProductInventory() { name = "pumpkin", price = 30, quantity = 30, type = "Marrow" },
                new ProductInventory() { name = "cauliflower", price = 10, quantity = 25, type = "Cruciferous" },
                new ProductInventory() { name = "zucchini", price = 20.5, quantity = 50, type = "Marrow" },
                new ProductInventory() { name = "spinach", price = 10, quantity = 100, type = "Leafy green" },
                new ProductInventory() { name = "yam", price = 30, quantity = 50, type = "Root" },
                new ProductInventory() { name = "broccoli", price = 20.5, quantity = 75, type = "Cruciferous" },
                new ProductInventory() { name = "Garlic", price = 30, quantity = 20, type = "Leafy green" },
                new ProductInventory() { name = "silverbeet", price = 10, quantity = 50, type = "Marrow" }

            };
        }
      

        public IEnumerable<ProductInventory> GetAll()
        {
            return _products.OrderBy(r=>r.name);
        }

        public ProductInventory Update(string name)
        {
            return _products.FirstOrDefault(r => r.name == name);
            
        }

        public ProductInventory Add(ProductInventory newProduct)
        {
            _products.Add(newProduct);
            return newProduct;
        }

        public void Delete(ProductInventory newProduct)
        {
           
        }

        List<ProductInventory> _products;
    }
}
