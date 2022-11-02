using RaqamliAvlod.Domain.Entities.Questions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaqamliAvlod.Application.ViewModels.Questions.Commands
{
    public class QuestionUpdateViewModel
    {
        [Required, MinLength(5)]
        public string Title { get; set; } = String.Empty;
        [Required, MinLength(10)]
        public string Description { get; set; } = String.Empty;
        public string[]? Tags { get; set; }

        public static implicit operator QuestionUpdateViewModel(Question question)
        {
            return new QuestionUpdateViewModel()
            {
                Title = question.Title,
                Description = question.Description,
            };
        }
    }
}
