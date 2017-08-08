using System;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;

namespace BecketLee.Services
{
    public class EmailService : IEmailService
    {
        public async Task SendEmailAsync(string to, string subject, string body)
        {
            var message = FormMessage( to, "Do_Not_Reply@becket-lee.com", subject, body );

            using (var client = new SmtpClient())
            {
                client.Connect( "mail.host4asp.net", 465 );

                // Note: since we don't have an OAuth2 token, disable
                // the XOAUTH2 authentication mechanism.
                client.AuthenticationMechanisms.Remove( "XOAUTH2" );

                // Note: only needed if the SMTP server requires authentication
                //client.Authenticate( "Do_Not_Reply@becket-lee.com", "" );
                client.Authenticate( "", "" );

                await client.SendAsync( message );
                client.Disconnect( true );
            }

        }

        public void SendEmail(string to, string subject, string body)
        {
            var message = FormMessage( to, "Do_Not_Reply@becket-lee.com", subject, body );

            using (var client = new SmtpClient())
            {
                client.Connect( "mail.host4asp.net", 465 );
                // Note: since we don't have an OAuth2 token, disable
                // the XOAUTH2 authentication mechanism.
                client.AuthenticationMechanisms.Remove( "XOAUTH2" );

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate( "Do_Not_Reply@becket-lee.com", "" );

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

