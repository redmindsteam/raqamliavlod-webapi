using CodePower.DataAccess.Common;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.DataAccess.DbContexts;
using RaqamliAvlod.DataAccess.Interfaces.Submissions;
using RaqamliAvlod.Domain.Entities.Submissions;


namespace RaqamliAvlod.DataAccess.Repositories.Submissions
{
    public class SubmissionRepository : ISubmissionRepository
    {
        private readonly AppDbContext _dbSet;

        public SubmissionRepository(AppDbContext context)
        {
            _dbSet = context;
        }
        public async Task<Submission> CreateAsync(Submission entity)
        {
            await _dbSet.Submissions.AddAsync(entity); 
            await _dbSet.SaveChangesAsync();    

            return entity;
        }

        public async Task<Submission?> FindByIdAsync(long id)
        {
            return await _dbSet.Submissions.FindAsync(id);
        }

        public async Task<PagedList<Submission>> GetAllAsync(PaginationParams @params)
        {
            return await PagedList<Submission>.ToPagedListAsync((IQueryable<Submission>)_dbSet, @params.PageNumber, @params.PageSize);
        }
    }
}
