using CodePower.DataAccess.Common;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.DataAccess.DbContexts;
using RaqamliAvlod.DataAccess.Interfaces.Contests;
using RaqamliAvlod.Domain.Entities.Contests;

namespace RaqamliAvlod.DataAccess.Repositories.Contests
{
    public class ContestStandingsRepository : BaseRepository<ContestStandings>, IContestStandingsRepository
    {
        public ContestStandingsRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<PagedList<ContestStandings>> GetAllByContestIdAsync(long contestId, PaginationParams @params)
        {
            var contestStandings = _dbSet.Where(standings => standings.ContestId == contestId);

            return await PagedList<ContestStandings>.ToPagedListAsync(contestStandings, @params.PageNumber, @params.PageSize);
        }
    }
}
