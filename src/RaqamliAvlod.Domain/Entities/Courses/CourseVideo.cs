using RaqamliAvlod.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaqamliAvlod.Domain.Entities.Courses
{
    [Table("course_videos")]
    public class CourseVideo : Auditable
    {
        [Column("title")]
        public string Title { get; set; } = String.Empty;

        [Column("youtube_thumb")]
        public string YouTubeThumbnail { get; set; } = String.Empty;

        [Column("view_count")]
        public int ViewCount { get; set; } = 0;

        [Column("youtube_link")]
        public string YouTubeLink { get; set; } = String.Empty;

        [Column("description")]
        public string Description { get; set; } = String.Empty;

        [Column("duration")]
        public string Duration { get; set; } = string.Empty;

        [Column("course_id")]
        public long CourseId { get; set; }
        public virtual Course Course { get; set; } = null!;

    }
}
