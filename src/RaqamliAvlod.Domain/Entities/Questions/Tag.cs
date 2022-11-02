using RaqamliAvlod.Domain.Common;

namespace RaqamliAvlod.Domain.Entities.Questions
{
    public class Tag : BaseEntity
    {
        public string TagName { get; set; } = default!;
    }
}