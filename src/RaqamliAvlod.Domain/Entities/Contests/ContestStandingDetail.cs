using RaqamliAvlod.Domain.Common;
using RaqamliAvlod.Domain.Entities.ProblemSets;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaqamliAvlod.Domain.Entities.Contests
{
    [Table("contest_standing_details")]
    public class ContestStandingDetail : BaseEntity
    {
        [Column("is_fixed")]
        public bool IsFixed { get; set; }

        [Column("fixed_time")]
        public TimeOnly FixedTime { get; set; }

        [Column("penalty_submissions")]
        public short PenaltySubmissions { get; set; }

        [Column("problemset_id")]
        public long ProblemSetId { get; set; }
        public virtual ProblemSet ProblemSet { get; set; } = default!;

        [Column("contest_standing_id")]
        public long ContestStandingId { get; set; }
        public virtual ContestStanding ContestStanding { get; set; } = default!;
    }
}