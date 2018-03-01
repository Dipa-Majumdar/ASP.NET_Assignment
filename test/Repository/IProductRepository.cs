using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Models;

namespace test.Repository
{

    public interface IProductRepository
    {
        void List();
        void Add(ProductInventory prod);
        void Update();
        void Delete();
    }
    public class ProductImp : IProductRepository
    {
        List<ProductInventory> product_list = new List<ProductInventory>();
        void IProductRepository.List()
        {
            
            throw new NotImplementedException();
        }

        void IProductRepository.Add(ProductInventory prod)
        {
            product_list.Add(prod);
        }

        void IProductRepository.Update()
        {
            throw new NotImplementedException();
        }

        void IProductRepository.Delete()
        {
            throw new NotImplementedException();
        }
    }
}
