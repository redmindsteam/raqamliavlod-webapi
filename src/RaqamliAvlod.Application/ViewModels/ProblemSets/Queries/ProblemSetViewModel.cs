using RaqamliAvlod.Domain.Entities.ProblemSets;

namespace RaqamliAvlod.Application.ViewModels.ProblemSets.Queries
{
    public class ProblemSetViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public string Type { get; set; } = String.Empty;
        public string InputDescription { get; set; } = String.Empty;
        public string OutputDescription { get; set; } = String.Empty;
        public int TimeLimit { get; set; }
        public int MemoryLimit { get; set; }
        public byte Difficulty { get; set; }
        public bool IsPublic { get; set; }

        public string OwnerName { get; set; } = string.Empty;

        public static implicit operator ProblemSetViewModel(ProblemSet problemSet)
        {
            return new ProblemSetViewModel()
            {
                Id = problemSet.Id,
                Name = problemSet.Name,
                Description = problemSet.Description,
                Type = problemSet.Type,
                InputDescription = problemSet.InputDescription,
                OutputDescription = problemSet.OutputDescription,
                TimeLimit = problemSet.TimeLimit,
                MemoryLimit = problemSet.MemoryLimit,
                Difficulty = problemSet.Difficulty,
                IsPublic = problemSet.IsPublic,
            };
        }
    }
}
