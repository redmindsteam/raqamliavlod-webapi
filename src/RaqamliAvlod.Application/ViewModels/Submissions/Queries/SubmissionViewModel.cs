using RaqamliAvlod.Domain.Entities.Submissions;
using RaqamliAvlod.Domain.Entities.Users;

namespace RaqamliAvlod.Application.ViewModels.Submissions.Queries
{
    public class SubmissionViewModel
    {
        public string Result { get; set; } = String.Empty;
        public string Language { get; set; } = String.Empty;
        public int ExecutionTime { get; set; }
        public int MemoryUsage { get; set; }
        public int LengthOfCode { get; set; }
        public string Username { get; set; } = string.Empty;
        public long ProblemSetId { get; set; }
        public DateTime CreatedAt { get; set; }

        public static implicit operator SubmissionViewModel(Submission submission)
        {
            return new SubmissionViewModel()
            {
                Result = submission.Result,
                Language = submission.Language,
                ExecutionTime = submission.ExecutionTime,
                MemoryUsage = submission.MemoryUsage,
                LengthOfCode = submission.LengthOfCode,
                ProblemSetId = submission.ProblemSetId,
                CreatedAt = submission.CreatedAt,
            };
        }
    }
}
