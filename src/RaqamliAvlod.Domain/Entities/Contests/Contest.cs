using RaqamliAvlod.Domain.Common;

namespace RaqamliAvlod.Domain.Entities.Contests
{
    public class Contest : Auditable
    {
        public string Title { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsPublic { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
