
using Domain.Interfaces.InterfaceProducts;
using Entities.Entities;
using Infraestructure.Repository.Generics;

namespace Infraestructure.Repository.Repositories
{
    public class RepositoryProduct : RepositoryGenerics<Product>, IProduct 
    {     
    }
}
