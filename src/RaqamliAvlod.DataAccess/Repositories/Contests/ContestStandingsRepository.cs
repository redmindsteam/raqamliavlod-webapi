using RaqamliAvlod.DataAccess.DbContexts;
using RaqamliAvlod.DataAccess.Interfaces.Contests;
using RaqamliAvlod.Domain.Entities.Contests;


namespace RaqamliAvlod.DataAccess.Repositories.Contests
{
    public class ContestStandingsRepository : IContestStandingsRepository
    {
        private readonly AppDbContext _dbSet;

        public ContestStandingsRepository(AppDbContext context)
        {
            _dbSet = context;
        }
        public async Task<ContestStandings> CreateAsync(ContestStandings entity)
        {
            await _dbSet.ContestStandings.AddAsync(entity);
            await _dbSet.SaveChangesAsync();

            return entity;
        }

        public async Task<ContestStandings?> FindByIdAsync(long id)
        {
            return await _dbSet.ContestStandings.FindAsync(id);
        }

        public async Task<ContestStandings> UpdateAsync(long id, ContestStandings entity)
        {
            var oldEntity = await _dbSet.ContestStandings.FindAsync(id);
            if (oldEntity is not null)
            {
                entity.Id = id;
                _dbSet.ContestStandings.Update(entity);
                await _dbSet.SaveChangesAsync();
                return entity;
            }
            else throw new NullReferenceException("Not found entity to update");
        }
    }
}
