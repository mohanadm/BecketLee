using System.Threading.Tasks;

namespace BecketLee.Services
{
    public interface IEmailService
    {
        Task SendEmailAsync(string to, string from, string subject, string body);
        void SendEmail( string to, string from, string subject, string body );
    }
}