using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Trendyol.ShoppingCartApp.Repository.Interface;
using Trendyol.ShoppingCartApp.Repository.Models;
using Trendyol.ShoppingCartApp.Repository.Repository;
using Trendyol.ShoppingCartApp.Service.Interface;
using static Trendyol.ShoppingCartApp.Repository.Util.ExceptionHelper;

namespace Trendyol.ShoppingCartApp.Service.Service
{
    public class CategoryService :  ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IParentCategoryRepository _parentCategoryRepository;

        public CategoryService(ICategoryRepository categoryRepository, IParentCategoryRepository parentCategoryRepository)
        {
            _categoryRepository = categoryRepository;
            _parentCategoryRepository = parentCategoryRepository;
        }

        public async Task<Category> SaveCategoryAsync(Category category) => await DoWorkForRepositoryAsync(()=> _categoryRepository.SaveAsync(category), "ShoppingCart.SaveCategory");

        public async Task<Category> FindByIdCategoryAsync(decimal id) => await DoWorkForRepository(() => _categoryRepository.FindByIdAsync(id), "ShoppingCart.FindByIdCategory");

        public async Task<IEnumerable<Category>> FindAllCategoryAsync() => await DoWorkForRepository(() => _categoryRepository.FindAllAsync(), "ShoppingCart.FindAllCategory");

        public async Task DeleteByIdCategoryAsync(decimal id) => await DoWorkForRepositoryAsync(() => _categoryRepository.DeleteByIdAsync(id), "ShoppingCart.DeleteByIdCategory");

        public async Task DeleteCategoryAsync(Category category) => await DoWorkForRepositoryAsync(() => _categoryRepository.DeleteAsync(category), "ShoppingCart.DeleteCategory");

        public async Task SaveParentCategoryAsync(ParentCategory parentCategory) => await DoWorkForRepositoryAsync(() => _parentCategoryRepository.SaveAsync(parentCategory), "ShoppingCart.SaveParentCategory");

        public async Task<ParentCategory> FindByIdParentCategoryAsync(decimal id) => await DoWorkForRepositoryAsync(() => _parentCategoryRepository.FindByIdAsync(id), "ShoppingCart.FindByIdParentCategory");

        public async Task<IEnumerable<ParentCategory>> FindAllParentCategoryAsync(decimal id) => await DoWorkForRepositoryAsync(() => _parentCategoryRepository.FindAllAsync(), "ShoppingCart.FindByIdParentCategory");

        public async Task DeleteByIdParentCategoryAsync(decimal id) => await DoWorkForRepositoryAsync(() => _parentCategoryRepository.DeleteByIdAsync(id), "ShoppingCart.DeleteByIdParentCategory");
    }
}
