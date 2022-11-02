using RaqamliAvlod.Domain.Common;
using RaqamliAvlod.Domain.Entities.Users;

namespace RaqamliAvlod.Domain.Entities.Questions
{
    public class Question : Auditable
    {
        public string Title { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public int ViewCount { get; set; }

        public long OwnerId { get; set; }
        public virtual User Owner { get; set; } = null!;
    }
}
