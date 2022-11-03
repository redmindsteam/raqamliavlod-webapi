using RaqamliAvlod.Domain.Entities.Courses;
using System.ComponentModel.DataAnnotations;

namespace RaqamliAvlod.Infrastructure.Service.Dtos
{
    public class CourseVideoUpdateDto
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

        public static implicit operator CourseVideoUpdateDto(CourseVideo courseVideo)
        {
            return new CourseVideoUpdateDto()
            {
                Title = courseVideo.Title,
                YouTubeThumbnail = courseVideo.YouTubeThumbnail,
                YouTubeLink = courseVideo.YouTubeLink,
                Description = courseVideo.Description,
                CourseId = courseVideo.CourseId
            };
        }
    }
}
