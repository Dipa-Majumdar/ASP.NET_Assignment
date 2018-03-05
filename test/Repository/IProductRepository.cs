using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Models;

namespace test.Repository
{

    public interface IProductRepository
    {
        List<ProductInventory> List();
        List<ProductInventory> Add(ProductInventory prod);
        ProductInventory Update(string name);
        void Delete(string name);
    }
    
    public class ProductImp : IProductRepository
    {
        Database db=new Database();
        List<ProductInventory> product_list = new List<ProductInventory>();
       
        List<ProductInventory> IProductRepository.List()
        {
            return  (db.GetProductList());
        }

        List<ProductInventory> IProductRepository.Add(ProductInventory prod)
        {
            product_list.Add(prod);
            return product_list;
        }

        ProductInventory IProductRepository.Update(string Name)
        {
            var prodList=db.GetProductList();
            return prodList.FirstOrDefault(r => r.Name == Name);
        }



        void IProductRepository.Delete(string name)
        {
            throw new NotImplementedException();
        }

       
    }
}
