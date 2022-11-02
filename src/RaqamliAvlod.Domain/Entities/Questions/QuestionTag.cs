using RaqamliAvlod.Domain.Common;

namespace RaqamliAvlod.Domain.Entities.Questions
{
    public class QuestionTag : BaseEntity
    {
        public long QuestionId { get; set; }
        public virtual Question Question { get; set; } = default!;

        public long TagId { get; set; }
        public virtual Tag Tag { get; set; } = default!;
    }
}