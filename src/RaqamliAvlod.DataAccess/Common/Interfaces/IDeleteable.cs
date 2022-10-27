using RaqamliAvlod.Domain.Common;

namespace RaqamliAvlod.DataAccess.Common.Interfaces;

public interface IDeleteable<T> where T : BaseEntity
{
    public Task<T> DeleteAsync(long id);
}
