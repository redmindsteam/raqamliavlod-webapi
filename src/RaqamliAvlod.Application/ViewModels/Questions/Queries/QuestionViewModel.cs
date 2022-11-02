using RaqamliAvlod.Domain.Entities.Questions;

namespace RaqamliAvlod.Application.ViewModels.Questions.Queries
{
    public class QuestionViewModel
    {
        public long Id { get; set; }
        public string Title { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public int ViewCount { get; set; }
        public string[]? Tags { get; set; }

        public static implicit operator QuestionViewModel(Question question)
        {
            return new QuestionViewModel()
            {
                Id = question.Id,
                Title = question.Title,
                Description = question.Description,
                ViewCount = question.ViewCount,
            };
        }
    }
}
