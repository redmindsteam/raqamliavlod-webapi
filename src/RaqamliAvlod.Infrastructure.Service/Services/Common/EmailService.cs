using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Configuration;
using MimeKit;
using MimeKit.Text;
using RaqamliAvlod.Application.ViewModels.Common;
using RaqamliAvlod.Infrastructure.Service.Interfaces.Common;


namespace RaqamliAvlod.Infrastructure.Service.Services.Common
{
    public class EmailService : IEmailService
    {
        private readonly IConfigurationSection _config;

        public EmailService(IConfigurationSection config)
        {
            _config = config;   
        }

        public async Task SendEmailAsync(EmailMessage message)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(_config["EmailAddress"]));
            email.To.Add(MailboxAddress.Parse(message.To));
            email.Subject = message.Subject;
            email.Body = new TextPart(TextFormat.Html) { Text = message.Body.ToString()};

            var smtp = new SmtpClient();
            await smtp.ConnectAsync(_config["Host"], 587, SecureSocketOptions.StartTls);
            await smtp.AuthenticateAsync(_config["EmailAddress"], _config["Password"]);
            await smtp.SendAsync(email);
            await smtp.DisconnectAsync(true);
        }
    }
}
