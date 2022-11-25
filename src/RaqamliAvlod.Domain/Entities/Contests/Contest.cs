using RaqamliAvlod.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaqamliAvlod.Domain.Entities.Contests
{
    [Table("contests")]
    public class Contest : Auditable
    {
        [Column("title")]
        public string Title { get; set; } = String.Empty;
        
        [Column("description")]
        public string Description { get; set; } = String.Empty;

        [Column("start_date")]
        public DateTime StartDate { get; set; }

        [Column("end_date")]
        public DateTime EndDate { get; set; }

        [Column("is_calculated")]
        public bool IsCalculated { get; set; }

        [Column("is_public")]
        public bool IsPublic { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [Column("calculated_at")]
        public DateTime CalculatedAt { get; set; }
    }
}
