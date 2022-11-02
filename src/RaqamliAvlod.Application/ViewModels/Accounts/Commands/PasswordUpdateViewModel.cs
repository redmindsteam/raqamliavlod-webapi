using System.ComponentModel.DataAnnotations;

namespace RaqamliAvlod.Application.ViewModels.Common.Commands
{
    public class PasswordUpdateViewModel
    {
        [Required]
        public string OldPassword { get; set; } = string.Empty;
        [Required]
        public string NewPassword { get; set; } = string.Empty;
        [Required]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
