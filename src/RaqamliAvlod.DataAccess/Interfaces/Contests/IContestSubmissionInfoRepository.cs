using CodePower.DataAccess.Common;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.Domain.Entities.Contests;

namespace RaqamliAvlod.DataAccess.Interfaces.Contests
{
    public interface IContestSubmissionInfoRepository : IRepository<ContestSubmissionsInfo>
    {
        public Task<PagedList<ContestSubmissionsInfo>> GetAllByContestIdAsync(long contestId, PaginationParams @params);
    }
}