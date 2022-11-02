using RaqamliAvlod.Domain.Entities.Courses;
using System.ComponentModel.DataAnnotations;

namespace RaqamliAvlod.Application.ViewModels.Courses.Commands
{
    public class CourseVideoCreateViewModel
    {
        [Required, MinLength(5)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string YouTubeThumbnail { get; set; } = string.Empty;

        [Required]
        public string YouTubeLink { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public long CourseId { get; set; }

        public static implicit operator CourseVideo(CourseVideoCreateViewModel courseVideoCreateViewModel)
        {
            return new CourseVideo()
            {
                Title = courseVideoCreateViewModel.Title,
                YouTubeThumbnail = courseVideoCreateViewModel.YouTubeThumbnail,
                YouTubeLink = courseVideoCreateViewModel.YouTubeLink,
                Description = courseVideoCreateViewModel.Description,
                CourseId = courseVideoCreateViewModel.CourseId,
            };
        }
    }
}
