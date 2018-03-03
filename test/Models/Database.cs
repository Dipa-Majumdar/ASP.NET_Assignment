using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test.Models
{
    public class Database
    {
        List<ProductInventory> product_list = new List<ProductInventory>();
        public List<ProductInventory> GetProductList()
        {
            product_list.Add((new ProductInventory() { name = "lettuce", price = 10.5, quantity = 50, type = "Leafy green" }));
            product_list.Add(new ProductInventory() { name = "cabbage", price = 20, quantity = 100, type = "Cruciferous" });
            product_list.Add(new ProductInventory() { name = "pumpkin", price = 30, quantity = 30, type = "Marrow" });
            product_list.Add(new ProductInventory() { name = "cauliflower", price = 10, quantity = 25, type = "Cruciferous" });
            product_list.Add(new ProductInventory() { name = "zucchini", price = 20.5, quantity = 50, type = "Marrow" });
            product_list.Add(new ProductInventory() { name = "spinach", price = 10, quantity = 100, type = "Leafy green" });
            product_list.Add(new ProductInventory() { name = "yam", price = 30, quantity = 50, type = "Root" });
            product_list.Add(new ProductInventory() { name = "broccoli", price = 20.5, quantity = 75, type = "Cruciferous" });
            product_list.Add(new ProductInventory() { name = "Garlic", price = 30, quantity = 20, type = "Leafy green" });
            product_list.Add(new ProductInventory() { name = "silverbeet", price = 10, quantity = 50, type = "Marrow" });

            return product_list;
        }
       
        


    }
}
