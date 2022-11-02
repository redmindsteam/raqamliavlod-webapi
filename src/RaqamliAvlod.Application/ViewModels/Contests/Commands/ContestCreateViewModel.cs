using RaqamliAvlod.Domain.Entities.Contests;
using System.ComponentModel.DataAnnotations;

namespace RaqamliAvlod.Application.ViewModels.Contests.Commands
{
    public class ContestCreateViewModel
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

        public static implicit operator Contest(ContestCreateViewModel contestCreateViewModel)
        {
            return new Contest()
            {
                Title = contestCreateViewModel.Title,
                Description = contestCreateViewModel.Description,
                StartDate = contestCreateViewModel.StartDate,
                EndDate = contestCreateViewModel.EndDate,
                IsPublic = contestCreateViewModel.IsPublic,
            };
        }
    }
}
