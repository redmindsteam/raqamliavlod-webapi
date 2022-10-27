using RaqamliAvlod.Domain.Common;
using RaqamliAvlod.Domain.Enums;

namespace RaqamliAvlod.Domain.Entities.Users
{
    public class User : Auditable
    {
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string Username { get; set; } = String.Empty;
        public string ImagePath { get; set; } = String.Empty;
        public int ContestCoins { get; set; }
        public int ProblemSetCoins { get; set; }
        public string PhoneNumber { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; } = String.Empty;
        public string Salt { get; set; } = String.Empty;
        public DateTime UpdatedAt { get; set; }
        public UserRole Role { get; set; }
    }
}
