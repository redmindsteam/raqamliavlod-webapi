using CodePower.DataAccess.Common.Interfaces;
using RaqamliAvlod.DataAccess.Common.Interfaces;
using RaqamliAvlod.Domain.Entities.ProblemSets;

namespace RaqamliAvlod.DataAccess.Interfaces.ProblemSets
{
    public interface IProblemSetTestRepository
        : ICreateable<ProblemSetTest>, IReadable<ProblemSetTest>, IUpdateable<ProblemSetTest>, IDeleteable<ProblemSetTest>
    {

    }
}
