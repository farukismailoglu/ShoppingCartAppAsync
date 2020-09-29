using System;
using System.Collections.Generic;
using System.Text;
using Trendyol.ShoppingCartApp.Repository.Interface;
using Trendyol.ShoppingCartApp.Repository.Models;
using Trendyol.ShoppingCartApp.Service.Interface;
using Trendyol.ShoppingCartApp.Service.Util;

namespace Trendyol.ShoppingCartApp.Service.Service
{
    public class DeliveryCostService : IDeliveryCostService
    {
        private readonly ICartRepository _cartRepository;

        private const decimal deliveryCost = 1.2m, productDeliveryCost = 0.9m;

        public DeliveryCostService(ICartRepository cartRepository) => _cartRepository = cartRepository;

        //TODO
        



    }
}
