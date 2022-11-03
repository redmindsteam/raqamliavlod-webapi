using System.ComponentModel.DataAnnotations;

namespace RaqamliAvlod.Infrastructure.Service.Dtos
{
    public class ContestProblemSetCreateDto : ProblemSetCreateDto
    {
        [Required]
        public short ContestCoins { get; set; }

        [Required]
        public char ContestIdentifier { get; set; }

        [Required]
        public long ContestId { get; set; }
    }
}