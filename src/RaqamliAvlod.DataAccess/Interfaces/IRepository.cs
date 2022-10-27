using CodePower.DataAccess.Common.Interfaces;
using RaqamliAvlod.DataAccess.Common.Interfaces;
using RaqamliAvlod.Domain.Common;

namespace RaqamliAvlod.DataAccess.Interfaces
{
    public interface IRepository<T> : ICreateable<T>,
        IUpdateable<T>, IFindable<T>, IDeleteable<T>
        where T : BaseEntity
    {

    }
}