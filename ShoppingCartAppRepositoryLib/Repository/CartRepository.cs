using Trendyol.ShoppingCartApp.Repository.Interface;
using Trendyol.ShoppingCartApp.Repository.Models;

namespace Trendyol.ShoppingCartApp.Repository.Repository
{
    public class CartRepository : BaseRepository<Cart, decimal>, ICartRepository
    {
        public CartRepository():base(new Data.ShoppingCartAppDbContext())
        { }
    }
}
