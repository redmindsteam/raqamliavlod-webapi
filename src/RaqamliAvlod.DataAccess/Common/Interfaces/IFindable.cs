using RaqamliAvlod.Domain.Common;

namespace CodePower.DataAccess.Common.Interfaces;

public interface IFindable<T> where T : BaseEntity
{
    public Task<T?> FindByIdAsync(long id);
}
