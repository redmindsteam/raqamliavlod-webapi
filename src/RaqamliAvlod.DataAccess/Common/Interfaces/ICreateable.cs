using RaqamliAvlod.Domain.Common;

namespace RaqamliAvlod.DataAccess.Common.Interfaces;

public interface ICreateable<T> where T : BaseEntity
{
    public Task<T> CreateAsync(T entity);
}
