using RaqamliAvlod.Domain.Common;
using RaqamliAvlod.Domain.Entities.Users;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaqamliAvlod.Domain.Entities.Courses
{
    [Table("course_comments")]
    public class CourseComment : Auditable
    {
        [Column("comment_text")]
        public string CommentText { get; set; } = String.Empty;
        
        [Column("course_id")]
        public long CourseId { get; set; }
        public Course Course { get; set; } = null!;

        [Column("owner_id")]
        public long OwnerId { get; set; }
        public virtual User Owner { get; set; } = null!;
    }
}
