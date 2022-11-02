using RaqamliAvlod.Domain.Entities.ProblemSets;

namespace RaqamliAvlod.DataAccess.Interfaces.ProblemSets
{
    public interface IProblemSetTestRepository
        : IRepository<ProblemSetTest>
    {
        public Task<IEnumerable<ProblemSetTest>> GetAllByProblemSetId(long problemSetId);
    }
}
