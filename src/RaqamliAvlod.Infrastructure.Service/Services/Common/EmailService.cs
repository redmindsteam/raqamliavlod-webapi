using Microsoft.Extensions.Configuration;
using RaqamliAvlod.Application.ViewModels.Common;
using RaqamliAvlod.Infrastructure.Service.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaqamliAvlod.Infrastructure.Service.Services.Common
{
    public class EmailService : IEmailService
    {
        private readonly IConfigurationSection _config;

        public EmailService(IConfigurationSection config)
        {
            _config = config;
        }

        public Task SendEmailAsync(EmailMessage message)
        {
            throw new NotImplementedException();
        }
    }
}
