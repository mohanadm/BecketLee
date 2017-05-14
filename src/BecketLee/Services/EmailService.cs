using System.Threading.Tasks;

namespace BecketLee.Services
{
    public class EmailService : IEmailService
    {
        public async Task SendEmailAsync(string to, string from, string subject, string body)
        {
            throw new System.NotImplementedException();
            
        }

        public void SendEmail(string to, string @from, string subject, string body)
        {
            throw new System.NotImplementedException();
        }
    }

}