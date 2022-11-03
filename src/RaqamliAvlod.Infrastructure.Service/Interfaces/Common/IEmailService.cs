using RaqamliAvlod.Infrastructure.Service.Dtos;

namespace RaqamliAvlod.Infrastructure.Service.Interfaces.Common
{
    public interface IEmailService
    {
        public Task SendAsync(EmailMessage message);
    }
}
