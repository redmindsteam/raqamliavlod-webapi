using System;
using System.ComponentModel.DataAnnotations;

namespace RaqamliAvlod.Application.ViewModels.ProblemSets.Commands
{
    public class ContestProblemSetCreateViewModel : ProblemSetCreateViewModel
    {
        [Required]
        public short ContestCoins { get; set; }

        [Required]
        public char ContestIdentifier { get; set; }

        [Required]
        public long ContestId { get; set; }
    }
}