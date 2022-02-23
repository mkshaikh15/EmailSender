using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Services
{
    public interface IMailService
    {
        //Task<bool> SendEmailAsync(MailRequest mailRequest);
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
