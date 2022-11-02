using CodePower.DataAccess.Common;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.DataAccess.DbContexts;
using RaqamliAvlod.DataAccess.Interfaces.Contests;
using RaqamliAvlod.Domain.Entities.Contests;

namespace RaqamliAvlod.DataAccess.Repositories.Contests
{
    public class ContestSubmissionInfoRepository : BaseRepository<ContestSubmissionsInfo>, IContestSubmissionInfoRepository
    {
        public ContestSubmissionInfoRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<PagedList<ContestSubmissionsInfo>> GetAllByContestIdAsync(long contestId, PaginationParams @params)
        {
            var submissionInfo = _dbSet.Where(info => info.ContestStandingsId == contestId);

            return await PagedList<ContestSubmissionsInfo>.ToPagedListAsync(submissionInfo, @params.PageNumber, @params.PageSize);
        }
    }
}
