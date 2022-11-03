using Microsoft.EntityFrameworkCore;
using RaqamliAvlod.DataAccess.DbContexts;
using RaqamliAvlod.DataAccess.Interfaces.Users;
using RaqamliAvlod.Domain.Entities.Users;

namespace RaqamliAvlod.DataAccess.Repositories.Users
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<User?> GetByEmailAsync(string email)
        {
            return await _dbcontext.Users.FirstOrDefaultAsync(user => user.Email == email);
        }
    }
}
