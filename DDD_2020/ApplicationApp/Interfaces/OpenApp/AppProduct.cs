using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationApp.Interfaces.OpenApp
{
    public class AppProduct : IProductApp
    {
        public Task Add(Product Objeto)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Product Objeto)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetEntityById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> List()
        {
            throw new NotImplementedException();
        }

        public Task Update(Product Objeto)
        {
            throw new NotImplementedException();
        }
    }
}
