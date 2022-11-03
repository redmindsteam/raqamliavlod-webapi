using RaqamliAvlod.Domain.Entities.Courses;
using System.ComponentModel.DataAnnotations;

namespace RaqamliAvlod.Infrastructure.Service.Dtos
{
    public class CourseVideoCreateDto
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

        public static implicit operator CourseVideo(CourseVideoCreateDto courseVideoCreateDto)
        {
            return new CourseVideo()
            {
                Title = courseVideoCreateDto.Title,
                YouTubeThumbnail = courseVideoCreateDto.YouTubeThumbnail,
                YouTubeLink = courseVideoCreateDto.YouTubeLink,
                Description = courseVideoCreateDto.Description,
                CourseId = courseVideoCreateDto.CourseId,
            };
        }
    }
}
