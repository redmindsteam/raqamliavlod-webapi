using RaqamliAvlod.Domain.Entities.Users;

namespace RaqamliAvlod.DataAccess.Interfaces.Users
{
    public interface IUserRepository : IGenericRepository<User>
    {
        public Task<User?> GetByEmailAsync(string email);
    }
}
