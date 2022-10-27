using RaqamliAvlod.Domain.Common;

namespace RaqamliAvlod.Domain.Entities.Courses
{
    public class CourseVideo : Auditable
    {
        public string Title { get; set; } = String.Empty;
        public string YouTubeThumbnail { get; set; } = String.Empty;
        public int ViewCount { get; set; }
        public string YouTubeLink { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;

        public long CourseId { get; set; }
        public virtual Course Course { get; set; } = null!;

    }
}
