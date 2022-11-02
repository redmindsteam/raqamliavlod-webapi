using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaqamliAvlod.Application.ViewModels.Courses.Commands
{
    public class CourseCommentUpdateViewModel
    {
        [Required]
        public string CommentText { get; set; } = string.Empty;

    }
}
