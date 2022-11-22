namespace RaqamliAvlod.Infrastructure.Core.Models
{
    public class CheckerSubmissionDetails : CheckerSubmissionOptions
    {
        public string ProblemKey { get; set; } = String.Empty;

        public string Language { get; set; } = String.Empty;

        public byte[] Code { get; set; } = null!;

        public string CodeFileName { get; set; } = String.Empty;

        public ushort TimeLimit { get; set; }

        public uint MemoryLimit { get; set; }
    }
}