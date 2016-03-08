using System.Threading.Tasks;

namespace Mvc5TestApp.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
