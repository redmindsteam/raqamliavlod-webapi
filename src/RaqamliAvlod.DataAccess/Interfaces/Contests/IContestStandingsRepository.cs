using CodePower.DataAccess.Common;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.Domain.Entities.Contests;

namespace RaqamliAvlod.DataAccess.Interfaces.Contests
{
    public interface IContestStandingsRepository
        : IRepository<ContestStanding>
    {
        public Task<PagedList<ContestStanding>> GetAllByContestIdAsync(long contestId, PaginationParams @params);
    }
}
