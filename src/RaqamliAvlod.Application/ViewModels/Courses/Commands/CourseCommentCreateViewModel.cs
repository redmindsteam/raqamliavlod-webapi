using RaqamliAvlod.Domain.Entities.Courses;
using System.ComponentModel.DataAnnotations;

namespace RaqamliAvlod.Application.ViewModels.Courses.Commands
{
    public class CourseCommentCreateViewModel
    {
        [Required, MinLength(3)]
        public string CommentText { get; set; } = string.Empty;
        [Required]
        public long CourseId { get; set; }

        public static implicit operator CourseComment(CourseCommentCreateViewModel courseCommentCreateViewModel)
        {
            return new CourseComment()
            {
                CommentText = courseCommentCreateViewModel.CommentText,
                CourseId = courseCommentCreateViewModel.CourseId,
            };
        }

    }
}
