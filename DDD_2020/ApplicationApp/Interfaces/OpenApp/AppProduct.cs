using Domain.Interfaces.InterfaceProducts;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationApp.Interfaces.OpenApp
{
    public class AppProduct : IProductApp
    {
        IProduct _Iproduct;
        public AppProduct(IProduct IProduct)
        {
            _Iproduct = IProduct;
        }

        public async Task Add(Product Objeto)
        {
            await _Iproduct.Add(Objeto);
        }

        public async Task Delete(Product Objeto)
        {
            await _Iproduct.Delete(Objeto);
        }

        public async Task<Product> GetEntityById(int Id)
        {
            return await _Iproduct.GetEntityById(Id);
        }

        public async Task<List<Product>> List()
        {
            return await _Iproduct.List();
        }

        public async Task Update(Product Objeto)
        {
            await _Iproduct.Update(Objeto);
        }
    }
}
