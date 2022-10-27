using CodePower.DataAccess.Common;
using Microsoft.EntityFrameworkCore;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.DataAccess.DbContexts;
using RaqamliAvlod.DataAccess.Interfaces;
using RaqamliAvlod.Domain.Common;

namespace RaqamliAvlod.DataAccess.Repositories
{
    public class GenericRepository<T> : BaseRepository<T>, IGenericRepository<T> where T : BaseEntity
    {
        public GenericRepository(AppDbContext context) : base(context)
        {
        }

        public virtual async Task<PagedList<T>> GetAllAsync(PaginationParams @params)
        {
            return await PagedList<T>.ToPagedListAsync(_dbSet, @params.PageNumber, @params.PageSize);
        }
    }
}