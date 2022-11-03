using RaqamliAvlod.Domain.Entities.Questions;
using System.ComponentModel.DataAnnotations;

namespace RaqamliAvlod.Infrastructure.Service.Dtos
{
    public class QuestionUpdateDto
    {
        [Required, MinLength(5)]
        public string Title { get; set; } = String.Empty;
        [Required, MinLength(10)]
        public string Description { get; set; } = String.Empty;
        public string[]? Tags { get; set; }

        public static implicit operator QuestionUpdateDto(Question question)
        {
            return new QuestionUpdateDto()
            {
                Title = question.Title,
                Description = question.Description,
            };
        }
    }
}
