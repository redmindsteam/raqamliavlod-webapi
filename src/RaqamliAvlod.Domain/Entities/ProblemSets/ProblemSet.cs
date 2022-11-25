using RaqamliAvlod.Domain.Common;
using RaqamliAvlod.Domain.Entities.Contests;
using RaqamliAvlod.Domain.Entities.Users;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaqamliAvlod.Domain.Entities.ProblemSets
{
    [Table("problemsets")]
    public class ProblemSet : Auditable
    {
        [Column("name")]
        public string Name { get; set; } = String.Empty;

        [Column("description")]
        public string Description { get; set; } = String.Empty;

        [Column("type")]
        public string Type { get; set; } = String.Empty;

        [Column("input_desciption")]
        public string InputDescription { get; set; } = String.Empty;

        [Column("output_desciption")]
        public string OutputDescription { get; set; } = String.Empty;

        [Column("note")]
        public string Note { get; set; } = String.Empty;

        [Column("time_limit")]
        public int TimeLimit { get; set; }

        [Column("memory_limit")]
        public int MemoryLimit { get; set; }

        [Column("difficulty")]
        public short Difficulty { get; set; }

        [Column("is_public")]
        public bool IsPublic { get; set; } = false;

        [Column("contest_coins")]
        public short ContestCoins { get; set; }

        [Column("contest_identifier")]
        public char ContestIdentifier { get; set; }

        [Column("owner_id")]
        public long OwnerId { get; set; }
        public virtual User Owner { get; set; } = null!;

        [Column("contest_id")]
        public long ContestId { get; set; }
        public virtual Contest Contest { get; set; } = null!;
    }
}
