using System;
using System.Collections.Generic;

namespace PdiwtA
{
    public interface IProductsRepository
    {
        Product GetById(Guid id);
        List<Product> GetAll();
        Product Save(Product product);
        Product Update(Product product);
        void DeleteByName(string name);
    }
}
