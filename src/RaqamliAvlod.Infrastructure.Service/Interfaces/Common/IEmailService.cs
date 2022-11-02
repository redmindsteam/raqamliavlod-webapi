using RaqamliAvlod.Application.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace RaqamliAvlod.Infrastructure.Service.Interfaces.Common
{
    public interface IEmailService
    {
        public Task SendAsync(EmailMessage message);
    }
}
