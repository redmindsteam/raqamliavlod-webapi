using RaqamliAvlod.Application.Attributes;
using System.ComponentModel.DataAnnotations;

namespace RaqamliAvlod.Application.ViewModels.Accounts.Commands
{
    public class AccountLoginViewModel
    {
        [Required, Email]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
