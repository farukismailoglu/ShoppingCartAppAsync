using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Trendyol.ShoppingCartApp.Repository.Interface;
using Trendyol.ShoppingCartApp.Repository.Models;
using Trendyol.ShoppingCartApp.Service.Interface;
using static Trendyol.ShoppingCartApp.Repository.Util.ExceptionHelper;

namespace Trendyol.ShoppingCartApp.Service.Service
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _cartRepository;

        public CartService(ICartRepository cartRepository) => _cartRepository = cartRepository;

        public async Task SaveCartAsync(CartItem cartItem) => await DoWorkForRepositoryAsync(() => _cartRepository.SaveAsync(cartItem), "");

        public async Task<IEnumerable<CartItem>> FindAllAsync() => await DoWorkForRepositoryAsync(() => _cartRepository.FindAllAsync(), "ShoppingCart.FindAll");

        public async Task<CartItem> FindByIdCartAsync(decimal id) => await DoWorkForRepositoryAsync(() => _cartRepository.FindByIdAsync(id), "ShoppingCart.FindByIdCart");

        //public async Task EmptyCart(decimal id) => await DoWorkForRepositoryAsync(() => _cartRepository.DeleteByIdAsync());
    }
}
