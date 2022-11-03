using RaqamliAvlod.Domain.Entities.Contests;
using System.ComponentModel.DataAnnotations;

namespace RaqamliAvlod.Infrastructure.Service.Dtos
{
    public class ContestCreateDto
    {
        [Required, MinLength(5)]
        public string Title { get; set; } = String.Empty;
        [Required, MinLength(5)]
        public string Description { get; set; } = String.Empty;
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public bool IsPublic { get; set; }

        public static implicit operator Contest(ContestCreateDto contestCreateDto)
        {
            return new Contest()
            {
                Title = contestCreateDto.Title,
                Description = contestCreateDto.Description,
                StartDate = contestCreateDto.StartDate,
                EndDate = contestCreateDto.EndDate,
                IsPublic = contestCreateDto.IsPublic,
            };
        }
    }
}
