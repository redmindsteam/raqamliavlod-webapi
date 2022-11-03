using RaqamliAvlod.Domain.Entities.Contests;

namespace RaqamliAvlod.Application.ViewModels.Contests
{
    public class ContestViewModel
    {
        public long Id { get; set; }
        public string Title { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ProblemSetCount { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsPublic { get; set; }

        public static implicit operator ContestViewModel(Contest contest)
        {
            return new ContestViewModel()
            {
                Id = contest.Id,
                Title = contest.Title,
                Description = contest.Description,
                StartDate = contest.StartDate,
                EndDate = contest.EndDate,
                IsCompleted = contest.IsCompleted,
                IsPublic = contest.IsPublic
            };
        }
    }
}
