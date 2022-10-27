namespace RaqamliAvlod.Domain.Common
{
    public class Auditable : BaseEntity
    {
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
