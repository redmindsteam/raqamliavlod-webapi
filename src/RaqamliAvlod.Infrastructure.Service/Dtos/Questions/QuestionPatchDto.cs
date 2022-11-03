using RaqamliAvlod.Domain.Entities.Questions;

namespace RaqamliAvlod.Infrastructure.Service.Dtos
{
    public class QuestionPatchDto
    {
        public string Title { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public string[]? Tags { get; set; }

        public static implicit operator Question(QuestionPatchDto question)
        {
            return new Question()
            {
                Title = question.Title,
                Description = question.Description,
            };
        }
    }
}
