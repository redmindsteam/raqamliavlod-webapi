using RaqamliAvlod.Domain.Entities.Questions;
using System.ComponentModel.DataAnnotations;

namespace RaqamliAvlod.Application.ViewModels.Questions.Commands
{
    public class QuestionCreateViewModel
    {
        [Required, MinLength(5)]
        public string Title { get; set; } = String.Empty;
        [Required, MinLength(10)]
        public string Description { get; set; } = String.Empty;
        public string[]? Tags { get; set; }

        public static implicit operator Question(QuestionCreateViewModel questionCreateViewModel)
        {
            return new Question()
            {
                Title = questionCreateViewModel.Title,
                Description = questionCreateViewModel.Description,
            };
        }
    }
}
