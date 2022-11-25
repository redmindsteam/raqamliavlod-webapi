using RaqamliAvlod.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaqamliAvlod.Domain.Entities.Questions
{
    [Table("tags")]
    public class Tag : BaseEntity
    {
        [Column("tag")]
        public string TagName { get; set; } = default!;

        [Column("view_count")]
        public int ViewCount { get; set; } = 0;
    }
}