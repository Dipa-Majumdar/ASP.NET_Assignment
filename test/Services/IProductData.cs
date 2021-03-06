﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Models;

namespace test.Services
{
   public interface IProductData
    {
        IEnumerable<ProductInventory> GetAll();
        ProductInventory Update(string name);
        ProductInventory Add(ProductInventory newProduct);
        void Delete(string name);
    }
   
}
