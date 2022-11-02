using RaqamliAvlod.Domain.Entities.ProblemSets;
using System.ComponentModel.DataAnnotations;

namespace RaqamliAvlod.Application.ViewModels.ProblemSets.Commands
{
    public class ProblemSetCreateViewModel
    {
        [Required]
        public string Name { get; set; } = String.Empty;

        [Required]
        public string Description { get; set; } = String.Empty;

        [Required]
        public string Type { get; set; } = String.Empty;

        public string Note { get; set; } = String.Empty;

        [Required]
        public string InputDescription { get; set; } = String.Empty;

        [Required]
        public string OutputDescription { get; set; } = String.Empty;

        [Required]
        public int TimeLimit { get; set; }

        [Required]
        public int MemoryLimit { get; set; }

        [Required]
        public byte Difficulty { get; set; }

        [Required]
        public bool IsPublic { get; set; }

        [Required]
        public long OwnerId { get; set; }

        public static implicit operator ProblemSet(ProblemSetCreateViewModel problemSetCreateViewModel)
        {
            return new ProblemSet()
            {
                Name = problemSetCreateViewModel.Name,
                Description = problemSetCreateViewModel.Description,
                Type = problemSetCreateViewModel.Type,
                InputDescription = problemSetCreateViewModel.InputDescription,
                OutputDescription = problemSetCreateViewModel.OutputDescription,
                TimeLimit = problemSetCreateViewModel.TimeLimit,
                MemoryLimit = problemSetCreateViewModel.MemoryLimit,
                Difficulty = problemSetCreateViewModel.Difficulty,
                IsPublic = problemSetCreateViewModel.IsPublic,
                OwnerId = problemSetCreateViewModel.OwnerId,
            };
        }
    }
}
