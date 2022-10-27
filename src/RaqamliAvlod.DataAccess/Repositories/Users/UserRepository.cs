using CodePower.DataAccess.Common;
using Microsoft.EntityFrameworkCore;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.DataAccess.DbContexts;
using RaqamliAvlod.DataAccess.Interfaces.Users;
using RaqamliAvlod.Domain.Entities.Users;

namespace RaqamliAvlod.DataAccess.Repositories.Users
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext;
        
        public UserRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User> CreateAsync(User entity)
        {
            await _dbContext.Users.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<User?> FindByIdAsync(long id)
        {
            return await _dbContext.Users.FindAsync(id);
        }

        public async Task<PagedList<User>> GetAllAsync(PaginationParams @params)
        {
            return await PagedList<User>.ToPagedListAsync(_dbContext.Users, @params.PageNumber, @params.PageSize);
        }

        public async Task<User> UpdateAsync(long id, User entity)
        {
            var oldEntity = await _dbContext.Users.FindAsync(id);
            if (oldEntity is not null)
            {
                entity.Id = id;
                _dbContext.Users.Update(entity);
                await _dbContext.SaveChangesAsync();
                return entity;
            }
            else throw new NullReferenceException("Not found entity to update");
        }
    }
}
