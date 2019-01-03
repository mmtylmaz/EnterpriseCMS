using System;
using System.Collections.Generic;
using System.Text;
using Abc.Northwind.Business.Abstract;
using Abc.Northwind.Entities.Concrete;

namespace Abc.Northwind.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
