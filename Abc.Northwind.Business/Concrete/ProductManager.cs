using System;
using System.Collections.Generic;
using System.Text;
using Abc.Northwind.Business.Abstract;
using Abc.Northwind.Entities.Concrete;

namespace Abc.Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Add(Product procuct)
        {
            throw new NotImplementedException();
        }

        public void Delete(int productId)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void Update(Product procuct)
        {
            throw new NotImplementedException();
        }
    }
}
