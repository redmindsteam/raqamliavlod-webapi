using RaqamliAvlod.Domain.Entities.Courses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaqamliAvlod.Application.ViewModels.Courses.Commands
{
    public class CourseVideoUpdateViewModel
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

        public static implicit operator CourseVideoUpdateViewModel(CourseVideo courseVideo)
        {
            return new CourseVideoUpdateViewModel()
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
