using System.ComponentModel.DataAnnotations.Schema;

namespace RaqamliAvlod.Domain.Common
{
    public class Auditable : BaseEntity
    {
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}
