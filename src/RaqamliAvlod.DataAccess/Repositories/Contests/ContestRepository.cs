using RaqamliAvlod.DataAccess.DbContexts;
using RaqamliAvlod.DataAccess.Interfaces.Contests;
using RaqamliAvlod.Domain.Entities.Contests;


namespace RaqamliAvlod.DataAccess.Repositories.Contests
{
    public class ContestRepository : GenericRepository<Contest>, IContestRepository
    {
        public ContestRepository(AppDbContext context) : base(context)
        {
        }
    }
}
