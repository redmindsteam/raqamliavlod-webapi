using RaqamliAvlod.Domain.Common;
using RaqamliAvlod.Domain.Entities.Users;

namespace RaqamliAvlod.Domain.Entities.Courses
{
    public class CourseComment : Auditable
    {
        public string CommentText { get; set; } = String.Empty;

        public long CourseId { get; set; }
        public Course Course { get; set; } = null!;

        public long OwnerId { get; set; }
        public virtual User Owner { get; set; } = null!;
    }
}
