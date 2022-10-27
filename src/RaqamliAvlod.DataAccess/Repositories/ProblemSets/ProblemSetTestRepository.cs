using CodePower.DataAccess.Common;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.DataAccess.DbContexts;
using RaqamliAvlod.DataAccess.Interfaces.ProblemSets;
using RaqamliAvlod.Domain.Entities.ProblemSets;


namespace RaqamliAvlod.DataAccess.Repositories.ProblemSets
{
    public class ProblemSetTestRepository : IProblemSetTestRepository
    {
        private readonly AppDbContext _dbSet;

        public ProblemSetTestRepository(AppDbContext context)
        {
            _dbSet = context;
        }
        public async Task<ProblemSetTest> CreateAsync(ProblemSetTest entity)
        {
            await _dbSet.AddAsync(entity);
            await _dbSet.SaveChangesAsync();

            return entity;
        }

        public async Task<ProblemSetTest> DeleteAsync(long id)
        {
            var entity = await _dbSet.ProblemSetTests.FindAsync(id);
            if (entity is not null)
            {
                _dbSet.Remove(entity);
                await _dbSet.SaveChangesAsync();
                return entity;
            }
            else throw new NullReferenceException("Not found entity to remove");
        }

        public async Task<PagedList<ProblemSetTest>> GetAllAsync(PaginationParams @params)
        {
            return await PagedList<ProblemSetTest>.ToPagedListAsync((IQueryable<ProblemSetTest>)_dbSet, @params.PageNumber, @params.PageSize);
        }

        public async Task<ProblemSetTest> UpdateAsync(long id, ProblemSetTest entity)
        {
            var oldEntity = await _dbSet.ProblemSetTests.FindAsync(id);
            if (oldEntity is not null)
            {
                entity.Id = id;
                _dbSet.prob.Update(entity);
                await _dbSet.SaveChangesAsync();
                return entity;
            }
            else throw new NullReferenceException("Not found entity to update");
        }
    }
}
