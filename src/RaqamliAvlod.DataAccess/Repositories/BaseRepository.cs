using Microsoft.EntityFrameworkCore;
using RaqamliAvlod.DataAccess.DbContexts;
using RaqamliAvlod.DataAccess.Interfaces;
using RaqamliAvlod.Domain.Common;

namespace RaqamliAvlod.DataAccess.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected AppDbContext _dbcontext;
        protected DbSet<T> _dbSet;

        public BaseRepository(AppDbContext context)
        {
            _dbcontext = context;
            _dbSet = context.Set<T>();
        }

        public virtual async Task<T> CreateAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _dbcontext.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<T> DeleteAsync(long id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity is not null)
            {
                _dbSet.Remove(entity);
                await _dbcontext.SaveChangesAsync();
                return entity;
            }
            else throw new NullReferenceException("Not found entity to remove");
        }

        public virtual async Task<T?> FindByIdAsync(long id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task<T> UpdateAsync(long id, T entity)
        {
            var oldEntity = await _dbSet.FindAsync(id);
            if (oldEntity is not null)
            {
                entity.Id = id;
                _dbSet.Update(entity);
                await _dbcontext.SaveChangesAsync();
                return entity;
            }
            else throw new NullReferenceException("Not found entity to update");
        }
    }
}