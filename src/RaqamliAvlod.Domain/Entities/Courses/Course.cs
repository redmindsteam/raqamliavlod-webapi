using RaqamliAvlod.Domain.Common;
using RaqamliAvlod.Domain.Entities.Users;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaqamliAvlod.Domain.Entities.Courses
{
    [Table("courses")]
    public class Course : Auditable
    {
        [Column("title")]
        public string Title { get; set; } = String.Empty;

        [Column("info")]
        public string Info { get; set; } = String.Empty;

        [Column("type")]
        public string Type { get; set; } = String.Empty;

        [Column("image_path")]
        public string ImagePath { get; set; } = String.Empty;

        [Column("price")]
        public float Price { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [Column("owner_id")]
        public long OwnerId { get; set; }
        public virtual User? Owner { get; set; }
    }
}
