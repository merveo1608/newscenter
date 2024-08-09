using NewsCenter.Models;

namespace Project.NewsCenter.EmailService
{
    public interface IEmailService
    {
        Task SendEmailAsync(MailRequest email);
    }
}
