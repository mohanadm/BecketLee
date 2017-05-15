using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;

namespace BecketLee.Services
{
    public class EmailService : IEmailService
    {
        public async Task SendEmailAsync(string to, string from, string subject, string body)
        {
            var message = FormMessage( to, from, subject, body );

            using (var client = new SmtpClient())
            {
                client.Connect( "smtp.gmail.com", 587 );

                // Note: since we don't have an OAuth2 token, disable
                // the XOAUTH2 authentication mechanism.
                client.AuthenticationMechanisms.Remove( "XOAUTH2" );

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate( "user", "password" );

                await client.SendAsync( message );
                client.Disconnect( true );
            }

        }

        public void SendEmail(string to, string @from, string subject, string body)
        {
            var message = FormMessage( to, from, subject, body );

            using (var client = new SmtpClient())
            {
                client.Connect( "smtp.gmail.com", 587 );

                // Note: since we don't have an OAuth2 token, disable
                // the XOAUTH2 authentication mechanism.
                client.AuthenticationMechanisms.Remove( "XOAUTH2" );

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate( "user", "password" );

                client.SendAsync( message );
                client.Disconnect( true );
            }
        }

        private static MimeMessage FormMessage( string to, string from, string subject, string body )
        {
            var message = new MimeMessage();
            message.From.Add( new MailboxAddress( "Becket & Lee LLP", from ) );
            message.To.Add( new MailboxAddress( to, to ) );
            message.Subject = subject;

            message.Body = new TextPart( "plain" )
            {
                Text = body
            };
            return message;
        }
    }

}