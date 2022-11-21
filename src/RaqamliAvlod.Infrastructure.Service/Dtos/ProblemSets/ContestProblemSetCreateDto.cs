using RaqamliAvlod.Domain.Entities.ProblemSets;
using RaqamliAvlod.Infrastructure.Service.Helpers;
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


        public static implicit operator ProblemSet(ContestProblemSetCreateDto problemSetCreateDto)
        {
            return new ProblemSet()
            {
                Name = problemSetCreateDto.Name,
                Description = problemSetCreateDto.Description,
                Type = problemSetCreateDto.Type,
                Note = problemSetCreateDto.Note,
                InputDescription = problemSetCreateDto.InputDescription,
                OutputDescription = problemSetCreateDto.OutputDescription,
                TimeLimit = problemSetCreateDto.TimeLimit,
                MemoryLimit = problemSetCreateDto.MemoryLimit,
                Difficulty = problemSetCreateDto.Difficulty,
                IsPublic = true,
                OwnerId = problemSetCreateDto.OwnerId,
                CreatedAt = TimeHelper.GetCurrentDateTime(),
                ContestCoins = problemSetCreateDto.ContestCoins,
                ContestIdentifier = problemSetCreateDto.ContestIdentifier,
                ContestId = problemSetCreateDto.ContestId,
            };
        }
    }
}