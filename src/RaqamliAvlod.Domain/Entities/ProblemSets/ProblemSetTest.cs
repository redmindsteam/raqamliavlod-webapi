using RaqamliAvlod.Domain.Common;

namespace RaqamliAvlod.Domain.Entities.ProblemSets
{
    public class ProblemSetTest : BaseEntity
    {
        public string Input { get; set; } = String.Empty;
        public string Output { get; set; } = String.Empty;

        public long ProblemSetId { get; set; }
        public virtual ProblemSet ProblemSet { get; set; } = null!;
    }
}
