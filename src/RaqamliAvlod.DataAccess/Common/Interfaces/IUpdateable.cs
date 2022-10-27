using RaqamliAvlod.Domain.Common;

namespace CodePower.DataAccess.Common.Interfaces;

public interface IUpdateable<T> where T : BaseEntity
{
    public Task<T> UpdateAsync(long id, T entity);
}
