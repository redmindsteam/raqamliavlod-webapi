using RaqamliAvlod.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaqamliAvlod.Domain.Entities.ProblemSets
{
    [Table("problemset_tests")]
    public class ProblemSetTest : BaseEntity
    {
        [Column("input")]
        public string Input { get; set; } = String.Empty;

        [Column("output")]
        public string Output { get; set; } = String.Empty;

        [Column("problemset_id")]
        public long ProblemSetId { get; set; }
        public virtual ProblemSet ProblemSet { get; set; } = null!;
    }
}
