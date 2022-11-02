using RaqamliAvlod.Domain.Common;
using RaqamliAvlod.Domain.Entities.Users;

namespace RaqamliAvlod.Domain.Entities.Contests
{
    public class ContestStandings : Auditable
    {
        public long UserId { get; set; }
        public virtual User User { get; set; } = null!;
        public long ContestId { get; set; }
        public virtual Contest Contest { get; set; } = null!;
        public int ResultCoins { get; set; }
        public int Penalty { get; set; }
    }
}
