namespace RaqamliAvlod.Application.ViewModels.Common
{
    public class ErrorResponseViewModel
    {
        public int StatusCode { get; set; }

        public string Message { get; set; } = default!;
    }
}