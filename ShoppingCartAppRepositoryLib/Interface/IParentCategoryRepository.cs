using System;
using System.Collections.Generic;
using System.Text;
using Trendyol.ShoppingCartApp.Repository.Models;

namespace Trendyol.ShoppingCartApp.Repository.Interface
{
    public interface IParentCategoryRepository : IBaseRepository<ParentCategory, decimal>
    {
    }
}
