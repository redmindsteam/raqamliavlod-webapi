namespace RaqamliAvlod.Infrastructure.Service.Dtos
{
    public class ErrorResponse
    {
        public int StatusCode { get; set; }

        public string Message { get; set; } = default!;
    }
}