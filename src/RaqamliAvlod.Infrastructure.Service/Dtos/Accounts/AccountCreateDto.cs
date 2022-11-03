using RaqamliAvlod.Attributes;
using RaqamliAvlod.Domain.Entities.Users;
using System.ComponentModel.DataAnnotations;

namespace RaqamliAvlod.Infrastructure.Service.Dtos
{
    public class AccountCreateDto
    {
        [Required, MinLength(3), Name]
        public string Firstname { get; set; } = string.Empty;
        [Required, MinLength(3), Name]
        public string Lastname { get; set; } = string.Empty;
        [Required]
        public string PhoneNumber { get; set; } = string.Empty;
        [Required, Email]
        public string Email { get; set; } = string.Empty;
        [Required, StrongPassword]
        public string Password { get; set; } = string.Empty;

        public static implicit operator User(AccountCreateDto accountCreateDto)
        {
            return new User()
            {
                FirstName = accountCreateDto.Firstname,
                LastName = accountCreateDto.Lastname,
                PhoneNumber = accountCreateDto.PhoneNumber,
                Email = accountCreateDto.Email,
            };
        }
    }
}
