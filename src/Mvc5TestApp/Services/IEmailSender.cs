using System.Threading.Tasks;

namespace Mvc5TestApp.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
