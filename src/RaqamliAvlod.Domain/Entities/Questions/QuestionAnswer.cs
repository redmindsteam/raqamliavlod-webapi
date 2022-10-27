using RaqamliAvlod.Domain.Common;
using RaqamliAvlod.Domain.Entities.Users;

namespace RaqamliAvlod.Domain.Entities.Questions
{
    public class QuestionAnswer : Auditable
    {
        public string Description { get; set; } = String.Empty;
        public bool HasReplied { get; set; }

        public long OwnerId { get; set; }
        public virtual User User { get; set; } = null!;

        public long QuestionId { get; set; }
        public virtual Question Question { get; set; } = null!;

        public long? ParentId { get; set; }
        public virtual QuestionAnswer? Answer { get; set; }

    }
}
