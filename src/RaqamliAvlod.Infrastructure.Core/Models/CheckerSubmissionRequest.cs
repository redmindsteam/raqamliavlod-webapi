namespace RaqamliAvlod.Infrastructure.Core.Models
{
    public class CheckerSubmissionRequest : CheckerSubmissionDetails
    {
        public string IdentityKey { get; set; } = String.Empty;

        public string Password { get; set; } = String.Empty;
    }
}
