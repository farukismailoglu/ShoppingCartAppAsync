using Trendyol.ShoppingCartApp.Repository.Data;
using Trendyol.ShoppingCartApp.Repository.Interface;
using Trendyol.ShoppingCartApp.Repository.Models;

namespace Trendyol.ShoppingCartApp.Repository.Repository
{
    public class CategoryRepository : BaseRepository<Category, decimal>, ICategoryRepository
    {
        public CategoryRepository():base(new ShoppingCartAppDbContext())
        { }

    }
}
