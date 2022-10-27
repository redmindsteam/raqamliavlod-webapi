using RaqamliAvlod.Domain.Common;
using RaqamliAvlod.Domain.Entities.Contests;
using RaqamliAvlod.Domain.Entities.Users;

namespace RaqamliAvlod.Domain.Entities.ProblemSets
{
    public class ProblemSet : Auditable
    {
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public string Type { get; set; } = String.Empty;
        public string InputDescription { get; set; } = String.Empty;
        public string OutputDescription { get; set; } = String.Empty;
        public int TimeLimit { get; set; }
        public int MemoryLimit { get; set; }
        public byte Difficulty { get; set; }
        public bool IsPublic { get; set; }

        public long OwnerId { get; set; }
        public virtual User User { get; set; } = null!;

        public long? ContestId { get; set; }
        public virtual Contest Contest { get; set; } = null!;
    }
}
