using RaqamliAvlod.Domain.Entities.Submissions;
using System.ComponentModel.DataAnnotations;

namespace RaqamliAvlod.Application.ViewModels.Submissions.Commands
{
    public class ContestSubmissionCreateViewModel : ProblemSetSubmissionCreateViewModel
    {
        [Required]
        public long ContestId { get; set; }
        
        public static implicit operator Submission(ContestSubmissionCreateViewModel contestSubmissionCreateViewModel)
        {
            return new Submission()
            {
                ContestId = contestSubmissionCreateViewModel.ContestId,
                ProblemSetId = contestSubmissionCreateViewModel.ProblemSetId,
                Language = contestSubmissionCreateViewModel.Language,
            };
        }
    }
}
