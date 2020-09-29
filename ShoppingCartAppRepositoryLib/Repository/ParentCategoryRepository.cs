using System;
using System.Collections.Generic;
using System.Text;
using Trendyol.ShoppingCartApp.Repository.Data;
using Trendyol.ShoppingCartApp.Repository.Interface;
using Trendyol.ShoppingCartApp.Repository.Models;

namespace Trendyol.ShoppingCartApp.Repository.Repository
{
    public class ParentCategoryRepository : BaseRepository<ParentCategory, decimal>, IParentCategoryRepository
    {
        public ParentCategoryRepository() : base(new ShoppingCartAppDbContext())
        { }

    }
}
