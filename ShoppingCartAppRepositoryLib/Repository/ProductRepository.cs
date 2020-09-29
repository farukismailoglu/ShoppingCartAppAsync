using System.Collections.Generic;
using Trendyol.ShoppingCartApp.Repository.Data;
using Trendyol.ShoppingCartApp.Repository.Interface;
using Trendyol.ShoppingCartApp.Repository.Models;

namespace Trendyol.ShoppingCartApp.Repository.Repository
{
    public class ProductRepository : BaseRepository<Product, decimal>, IProductRepository
    {
        public ProductRepository() : base(new ShoppingCartAppDbContext())
        { }

    }

}
