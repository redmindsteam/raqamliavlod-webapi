using RaqamliAvlod.Domain.Entities.Questions;
using System.ComponentModel.DataAnnotations;

namespace RaqamliAvlod.Infrastructure.Service.Dtos
{
    public class QuestionCreateDto
    {
        [Required, MinLength(5)]
        public string Title { get; set; } = String.Empty;
        [Required, MinLength(10)]
        public string Description { get; set; } = String.Empty;
        public string[]? Tags { get; set; }

        public static implicit operator Question(QuestionCreateDto questionCreateDto)
        {
            return new Question()
            {
                Title = questionCreateDto.Title,
                Description = questionCreateDto.Description,
            };
        }
    }
}
