namespace RaqamliAvlod.Infrastructure.Core.Models
{
    public class CheckerSubmissionOptions
    {
        public long SummissionId { get; set; }

        public bool IsTestable { get; set; }

        public string AppIdentifier { get; set; } = String.Empty;
    }
}