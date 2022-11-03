using Microsoft.AspNetCore.Http;
using RaqamliAvlod.Attributes;
using RaqamliAvlod.Domain.Entities.Submissions;
using System.ComponentModel.DataAnnotations;

namespace RaqamliAvlod.Infrastructure.Service.Dtos
{
    public class ProblemSetSubmissionCreateDto
    {
        [Required]
        public long ProblemSetId { get; set; }

        [Required]
        public string Language { get; set; } = string.Empty;

        [Required]
        [AllowedFiles(new string[] { ".c", ".cpp", ".py", ".java" })]
        public IFormFile Code { get; set; } = null!;

        public static implicit operator Submission(ProblemSetSubmissionCreateDto submissionCreateDto)
        {
            return new Submission()
            {
                ProblemSetId = submissionCreateDto.ProblemSetId,
                Language = submissionCreateDto.Language
            };
        }
    }
}
