using RaqamliAvlod.Domain.Entities.Submissions;
using System.ComponentModel.DataAnnotations;

namespace RaqamliAvlod.Infrastructure.Service.Dtos
{
    public class ContestSubmissionCreateDto : ProblemSetSubmissionCreateDto
    {
        [Required]
        public long ContestId { get; set; }

        public static implicit operator Submission(ContestSubmissionCreateDto contestSubmissionCreateDto)
        {
            return new Submission()
            {
                ContestId = contestSubmissionCreateDto.ContestId,
                ProblemSetId = contestSubmissionCreateDto.ProblemSetId,
                Language = contestSubmissionCreateDto.Language,
            };
        }
    }
}
