using RaqamliAvlod.Domain.Common;
using RaqamliAvlod.Domain.Entities.Users;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaqamliAvlod.Domain.Entities.Questions
{
    [Table("questions")]
    public class Question : Auditable
    {
        [Column("title")]
        public string Title { get; set; } = String.Empty;

        [Column("description")]
        public string Description { get; set; } = String.Empty;

        [Column("view_count")]
        public int ViewCount { get; set; } = 0;

        [Column("owner_id")]
        public long OwnerId { get; set; }
        public virtual User Owner { get; set; } = null!;
    }
}
