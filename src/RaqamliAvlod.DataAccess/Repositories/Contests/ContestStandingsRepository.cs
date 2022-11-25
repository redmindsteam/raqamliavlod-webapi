using CodePower.DataAccess.Common;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.DataAccess.DbContexts;
using RaqamliAvlod.DataAccess.Interfaces.Contests;
using RaqamliAvlod.Domain.Entities.Contests;

namespace RaqamliAvlod.DataAccess.Repositories.Contests
{
    public class ContestStandingsRepository : BaseRepository<ContestStanding>, IContestStandingsRepository
    {
        public ContestStandingsRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<PagedList<ContestStanding>> GetAllByContestIdAsync(long contestId, PaginationParams @params)
        {
            var contestStandings = _dbSet.Where(standings => standings.ContestId == contestId).OrderBy(x => x.Id);

            return await PagedList<ContestStanding>.ToPagedListAsync(contestStandings, @params.PageNumber, @params.PageSize);
        }
    }
}
