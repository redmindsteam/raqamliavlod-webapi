using System.ComponentModel.DataAnnotations;

namespace RaqamliAvlod.Infrastructure.Service.Dtos
{
    public class ProblemSetTestCreateDto
    {
        [Required]
        public string Input { get; set; } = String.Empty;

        [Required]
        public string Output { get; set; } = String.Empty;

        [Required]
        public long ProblemSetId { get; set; }
    }
}