using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Trendyol.ShoppingCartApp.Repository.Data;
using Trendyol.ShoppingCartApp.Repository.Interface;
using static Trendyol.ShoppingCartApp.Repository.Util.ExceptionHelper;

namespace Trendyol.ShoppingCartApp.Repository.Repository
{
    public class BaseRepository<Entity, ID> : IBaseRepository<Entity, ID>
        where Entity : class , IEntity<ID>
        
    {
        private readonly DbSet<Entity> m_entites;
        private ShoppingCartAppDbContext Ctx { get; set; }

        public BaseRepository(ShoppingCartAppDbContext context)
        {
            Ctx = context;
            m_entites = Ctx.Set<Entity>();
        }

        public Task<long> CountAsync() => m_entites.LongCountAsync();

        public Task DeleteAsync(Entity entity)
        => DeleteByIdAsync(entity.Id);

        public async Task DeleteByIdAsync(ID id)
        {
            var entity = await FindByIdAsync(id);

            if (entity != null)
                return;
            else
                m_entites.Remove(entity);
                
        }

        public Task<bool> ExitsByIdAsync(ID id)
        {
            var task = new Task<bool>(() => FindByIdAsync(id).Result != null);

            task.Start();

            return task;
        }

        public Task<IEnumerable<Entity>> FindAllAsync()
        {
            var task = new Task<IEnumerable<Entity>>(() => m_entites.ToList());

            task.Start();

            return task;
        }


        public Task<Entity> FindByIdAsync(ID id) =>  m_entites.FirstOrDefaultAsync(t => t.Id.Equals(id));

        public async Task<Entity> SaveAsync(Entity entity)
        {
            if (await ExitsByIdAsync(entity.Id))
                m_entites.Update(entity);
            else
                m_entites.Add(entity);

            await Ctx.SaveChangesAsync();

            return entity;
        }

        public IEnumerable<Entity> All() => m_entites.ToList();

    }
}
