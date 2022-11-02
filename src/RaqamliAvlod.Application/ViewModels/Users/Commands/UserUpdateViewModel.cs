using Microsoft.AspNetCore.Http;
using RaqamliAvlod.Application.Attributes;
using RaqamliAvlod.Domain.Entities.Users;
using System.ComponentModel.DataAnnotations;

namespace RaqamliAvlod.Application.ViewModels.Users.Commands
{
    public class UserUpdateViewModel
    {
        [Required, Name]
        public string Firstname { get; set; } = string.Empty;
        [Required]
        public string Lastname { get; set; } = string.Empty;
        [Required]
        public string Username { get; set; } = string.Empty;
        [Required]
        public string PhoneNumber { get; set; } = string.Empty;
        public IFormFile? Image { get; set; }

        public static implicit operator UserUpdateViewModel(User user)
        {
            return new UserUpdateViewModel()
            {
                Firstname = user.FirstName,
                Lastname = user.LastName,
                Username = user.Username,
                PhoneNumber = user.PhoneNumber,
            };
        }
    }


}
