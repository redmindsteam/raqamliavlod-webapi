using CodePower.DataAccess.Common;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.Domain.Entities.Contests;

namespace RaqamliAvlod.DataAccess.Interfaces.Contests
{
    public interface IContestStandingDetailRepository : IRepository<ContestStandingDetail>
    {
        public Task<PagedList<ContestStandingDetail>> GetAllByContestIdAsync(long contestId, PaginationParams @params);
    }
}