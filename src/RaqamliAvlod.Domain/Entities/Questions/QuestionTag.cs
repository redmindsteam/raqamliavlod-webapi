using RaqamliAvlod.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaqamliAvlod.Domain.Entities.Questions
{
    [Table("question_tags")]
    public class QuestionTag : BaseEntity
    {
        [Column("question_id")]
        public long QuestionId { get; set; }
        public virtual Question Question { get; set; } = default!;

        [Column("tag_id")]
        public long TagId { get; set; }
        public virtual Tag Tag { get; set; } = default!;
    }
}