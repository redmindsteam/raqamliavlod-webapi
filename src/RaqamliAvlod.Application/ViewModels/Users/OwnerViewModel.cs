namespace RaqamliAvlod.Application.ViewModels.Users
{
    public class OwnerViewModel
    {
        public long UserId { get; set; }

        public string FullName { get; set; } = default!;

        public string ImagePath { get; set; } = default!;
    }
}