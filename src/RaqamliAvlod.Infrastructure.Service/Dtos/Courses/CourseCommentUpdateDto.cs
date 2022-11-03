using System.ComponentModel.DataAnnotations;

namespace RaqamliAvlod.Infrastructure.Service.Dtos
{
    public class CourseCommentUpdateDto
    {
        [Required]
        public string CommentText { get; set; } = string.Empty;

    }
}
