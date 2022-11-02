using RaqamliAvlod.DataAccess.Common.Interfaces;
using RaqamliAvlod.Domain.Common;

namespace RaqamliAvlod.DataAccess.Interfaces
{
    public interface IGenericRepository<T> : IRepository<T>, IReadable<T>
        where T : BaseEntity
    {
    }
}