using System;
using System.Collections.Generic;
using System.Text;
using Trendyol.ShoppingCartApp.Repository.Models;

namespace Trendyol.ShoppingCartApp.Repository.Interface
{
    public interface ICartRepository : IBaseRepository<CartItem, decimal>
    {
    }
}
