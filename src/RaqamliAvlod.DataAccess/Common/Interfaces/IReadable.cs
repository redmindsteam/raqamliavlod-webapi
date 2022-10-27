using CodePower.DataAccess.Common;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.Domain.Common;

namespace RaqamliAvlod.DataAccess.Common.Interfaces
{
    public interface IReadable<T> where T : BaseEntity
    {
        public Task<PagedList<T>> GetAllAsync(PaginationParams @params);
    }
}