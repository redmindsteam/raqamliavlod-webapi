using System.ComponentModel.DataAnnotations;

namespace RaqamliAvlod.Application.ViewModels.ProblemSets.Commands
{
    public class ProblemSetTestCreateViewModel
    {
        [Required]
        public string Input { get; set; } = String.Empty;

        [Required]
        public string Output { get; set; } = String.Empty;

        [Required]
        public long ProblemSetId { get; set; }
    }
}