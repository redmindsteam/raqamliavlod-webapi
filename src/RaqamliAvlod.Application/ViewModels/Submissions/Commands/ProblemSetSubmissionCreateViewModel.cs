using Microsoft.AspNetCore.Http;
using RaqamliAvlod.Application.Attributes;
using RaqamliAvlod.Domain.Entities.Submissions;
using System.ComponentModel.DataAnnotations;
namespace RaqamliAvlod.Application.ViewModels.Submissions.Commands
{
    public class ProblemSetSubmissionCreateViewModel
    {
        [Required]
        public long ProblemSetId { get; set; }

        [Required]
        public string Language { get; set; } = string.Empty;

        [Required]
        [AllowedFiles(new string[] { ".c", ".cpp", ".py", ".java" })]
        public IFormFile Code { get; set; } = null!;

        public static implicit operator Submission(ProblemSetSubmissionCreateViewModel submissionCreateViewModel)
        {
            return new Submission()
            {
                ProblemSetId = submissionCreateViewModel.ProblemSetId,
                Language = submissionCreateViewModel.Language
            };
        }
    }
}
