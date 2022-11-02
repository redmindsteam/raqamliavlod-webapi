using RaqamliAvlod.Domain.Common;
using RaqamliAvlod.Domain.Entities.ProblemSets;

namespace RaqamliAvlod.Domain.Entities.Contests
{
    public class ContestSubmissionsInfo : BaseEntity
    {
        public bool IsFixed { get; set; }
        public TimeOnly FixedTime { get; set; }
        public short PenaltySubmissions { get; set; }

        public long ProblemSetId { get; set; }
        public virtual ProblemSet ProblemSet { get; set; } = default!;

        public long ContestStandingsId { get; set; }
        public virtual ContestStandings ContestStandings { get; set; } = default!;
    }
}