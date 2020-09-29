using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Trendyol.ShoppingCartApp.Repository.Models;

namespace Trendyol.ShoppingCartApp.Repository.Interface
{
    public interface IBaseRepository<T, ID> 
    {
        //IEnumerable<T> All();
        Task<IEnumerable<T>> FindAllAsync();
        Task<long> CountAsync();
        Task DeleteAsync(T t);
        Task DeleteByIdAsync(ID id);
        Task<bool> ExitsByIdAsync(ID id);
        Task<T> FindByIdAsync(ID id);
        Task<T> SaveAsync(T entity);

    }
}
