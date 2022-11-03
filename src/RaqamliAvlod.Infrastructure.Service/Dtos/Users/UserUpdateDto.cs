using Microsoft.AspNetCore.Http;
using RaqamliAvlod.Attributes;
using RaqamliAvlod.Domain.Entities.Users;
using System.ComponentModel.DataAnnotations;

namespace RaqamliAvlod.Infrastructure.Service.Dtos
{
    public class UserUpdateDto
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

        public static implicit operator UserUpdateDto(User user)
        {
            return new UserUpdateDto()
            {
                Firstname = user.FirstName,
                Lastname = user.LastName,
                Username = user.Username,
                PhoneNumber = user.PhoneNumber,
            };
        }
    }


}
