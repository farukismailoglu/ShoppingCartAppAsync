using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Trendyol.ShoppingCartApp.Repository.Interface;
using Trendyol.ShoppingCartApp.Repository.Models;
using Trendyol.ShoppingCartApp.Service.Interface;
using static Trendyol.ShoppingCartApp.Repository.Util.ExceptionHelper;


namespace Trendyol.ShoppingCartApp.Service.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository m_productRepository;
        public ProductService(IProductRepository productRepository) => m_productRepository = productRepository;

        public async Task SaveProductAsync(Product product)
        => await DoWorkForRepositoryAsync(() => m_productRepository.SaveAsync(product), "ShoppingCartAppService.SaveProductProduct");

        public async Task<Product> FindByIdProductAsync(decimal id)
            => await DoWorkForRepository(() => m_productRepository.FindByIdAsync(id), "ShoppingCartService.FindByIdProduct");

        public async Task<IEnumerable<Product>> FindAllProductAsync()
            => await DoWorkForRepository(() => m_productRepository.FindAllAsync(), "ShoppingCartService.FindByAllProduct");

        public async Task DeleteByIdProduct(decimal id)
            => await DoWorkForRepository(() => m_productRepository.DeleteByIdAsync(id), "ShoppingCartService.DeleteByIdProduct");

        public async Task DeleteProductAsync(Product product)
            => await DoWorkForRepository(() => m_productRepository.DeleteAsync(product), "ShoppingCartService.DeleteProduct");
    }
}
