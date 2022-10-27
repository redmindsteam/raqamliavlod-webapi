using CodePower.DataAccess.Common.Interfaces;
using RaqamliAvlod.DataAccess.Common.Interfaces;
using RaqamliAvlod.Domain.Entities.Submissions;

namespace RaqamliAvlod.DataAccess.Interfaces.Submissions
{
    public interface ISubmissionRepository : ICreateable<Submission>, IFindable<Submission>, IReadable<Submission>
    {

    }
}
