using RaqamliAvlod.DataAccess.DbContexts;
using RaqamliAvlod.DataAccess.Interfaces.Submissions;
using RaqamliAvlod.Domain.Entities.Submissions;


namespace RaqamliAvlod.DataAccess.Repositories.Submissions
{
    public class SubmissionRepository : GenericRepository<Submission>, ISubmissionRepository
    {
        public SubmissionRepository(AppDbContext context) : base(context)
        {

        }
    }
}
