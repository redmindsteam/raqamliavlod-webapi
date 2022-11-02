using RaqamliAvlod.Domain.Common;
using RaqamliAvlod.Domain.Entities.Users;

namespace RaqamliAvlod.Domain.Entities.Courses
{
    public class Course : Auditable
    {
        public string Title { get; set; } = String.Empty;
        public string Info { get; set; } = String.Empty;
        public string Type { get; set; } = String.Empty;
        public string ImagePath { get; set; } = String.Empty;
        public float Price { get; set; }
        public DateTime UpdatedAt { get; set; }

        public long OwnerId { get; set; }
        public virtual User? Owner { get; set; }
    }
}
