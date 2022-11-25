using RaqamliAvlod.Domain.Common;
using RaqamliAvlod.Domain.Entities.Users;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaqamliAvlod.Domain.Entities.Questions
{
    [Table("qestion_answers")]
    public class QuestionAnswer : Auditable
    {
        [Column("description")]
        public string Description { get; set; } = String.Empty;

        [Column("has_replied")]
        public bool HasReplied { get; set; } = false;

        [Column("owner_id")]
        public long OwnerId { get; set; }
        public virtual User Owner { get; set; } = null!;

        [Column("question_id")]
        public long QuestionId { get; set; }
        public virtual Question Question { get; set; } = null!;

        [Column("parent_id")]
        public long? ParentId { get; set; }
        public virtual QuestionAnswer? Parent { get; set; }
    }
}
