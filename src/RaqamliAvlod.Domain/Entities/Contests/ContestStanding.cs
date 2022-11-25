using RaqamliAvlod.Domain.Common;
using RaqamliAvlod.Domain.Entities.Users;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaqamliAvlod.Domain.Entities.Contests
{
    [Table("contest_standings")]
    public class ContestStanding : Auditable
    {
        [Column("user_id")]
        public long UserId { get; set; }
        public virtual User User { get; set; } = null!;

        [Column("contest_id")]
        public long ContestId { get; set; }
        public virtual Contest Contest { get; set; } = null!;

        [Column("result_coins")]
        public int ResultCoins { get; set; }

        [Column("penalty")]
        public int Penalty { get; set; }
    }
}
