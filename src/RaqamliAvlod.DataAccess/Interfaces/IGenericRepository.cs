using CodePower.DataAccess.Common.Interfaces;
using RaqamliAvlod.DataAccess.Common.Interfaces;
using RaqamliAvlod.Domain.Common;

namespace RaqamliAvlod.DataAccess.Interfaces
{
    public interface IGenericRepository<T> : ICreateable<T>,
        IReadable<T>, IUpdateable<T>, IFindable<T>, IDeleteable<T>
        where T : BaseEntity
    {
    }
}