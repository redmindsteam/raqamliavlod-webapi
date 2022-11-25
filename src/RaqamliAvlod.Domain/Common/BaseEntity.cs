using System.ComponentModel.DataAnnotations.Schema;

namespace RaqamliAvlod.Domain.Common
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
