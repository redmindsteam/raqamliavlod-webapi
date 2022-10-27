using RaqamliAvlod.Domain.Common;
using RaqamliAvlod.Domain.Entities.Contests;
using RaqamliAvlod.Domain.Entities.ProblemSets;
using RaqamliAvlod.Domain.Entities.Users;

namespace RaqamliAvlod.Domain.Entities.Submissions
{
    public class Submission : Auditable
    {
        public string Result { get; set; } = String.Empty;
        public string Language { get; set; } = String.Empty;
        public int ExecutionTime { get; set; }
        public int MemoryUsage { get; set; }
        public int LengthOfCode { get; set; }

        public long UserId { get; set; }
        public virtual User User { get; set; } = null!;

        public long ProblemSetId { get; set; }
        public virtual ProblemSet ProblemSet { get; set; } = null!;

        public long? ContestId { get; set; }
        public virtual Contest Contest { get; set; } = null!;
    }
}
