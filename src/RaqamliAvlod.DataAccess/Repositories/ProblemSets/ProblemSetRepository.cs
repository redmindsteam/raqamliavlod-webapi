using RaqamliAvlod.DataAccess.DbContexts;
using RaqamliAvlod.DataAccess.Interfaces.ProblemSets;
using RaqamliAvlod.Domain.Entities.ProblemSets;


namespace RaqamliAvlod.DataAccess.Repositories.ProblemSets
{
    public class ProblemSetRepository : GenericRepository<ProblemSet>, IProblemSetRepository
    {
        public ProblemSetRepository(AppDbContext context) : base(context)
        {
        }
    }
}
