using CodePower.DataAccess.Common;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.DataAccess.DbContexts;
using RaqamliAvlod.DataAccess.Interfaces.Contests;
using RaqamliAvlod.Domain.Entities.Contests;

namespace RaqamliAvlod.DataAccess.Repositories.Contests
{
    public class ContestStandingDetailRepository : BaseRepository<ContestStandingDetail>, IContestStandingDetailRepository
    {
        public ContestStandingDetailRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<PagedList<ContestStandingDetail>> GetAllByContestIdAsync(long contestId, PaginationParams @params)
        {
            var submissionInfo = _dbSet.Where(info => info.ContestStandingId == contestId)
                .OrderBy(x => x.Id);

            return await PagedList<ContestStandingDetail>.ToPagedListAsync(submissionInfo,
                @params.PageNumber, @params.PageSize);
        }
    }
}
