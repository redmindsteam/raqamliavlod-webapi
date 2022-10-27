using CodePower.DataAccess.Common.Interfaces;
using RaqamliAvlod.DataAccess.Common.Interfaces;
using RaqamliAvlod.Domain.Entities.Users;

namespace RaqamliAvlod.DataAccess.Interfaces.Users
{
    public interface IUserRepository 
        : ICreateable<User>, IReadable<User>, IFindable<User>, IUpdateable<User>
    {

    }
}
