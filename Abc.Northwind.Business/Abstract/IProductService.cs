using Abc.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Northwind.Business.Abstract
{
    public interface IProductService 
    {
        List<Product> GetAll();
        List<Product> GetByCategory(int categoryId);
        void Add(Product procuct);
        void Update(Product procuct);
        void Delete(int productId);
    }
}
