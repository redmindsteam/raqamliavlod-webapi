using RaqamliAvlod.Domain.Entities.Courses;

namespace RaqamliAvlod.Application.ViewModels.Courses
{
    public class CourseVideoViewModel
    {
        public long Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string YouTubeThumbnail { get; set; } = string.Empty;
        public int ViewCount { get; set; }
        public string YouTubeLink { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public string CourseName { get; set; } = string.Empty;

        public static implicit operator CourseVideoViewModel(CourseVideo courseVideo)
        {
            return new CourseVideoViewModel()
            {
                Id = courseVideo.Id,
                Title = courseVideo.Title,
                YouTubeThumbnail = courseVideo.YouTubeThumbnail,
                ViewCount = courseVideo.ViewCount,
                YouTubeLink = courseVideo.YouTubeLink,
                Description = courseVideo.Description,
            };
        }
    }
}
