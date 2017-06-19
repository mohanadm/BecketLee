using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace BecketLee.Services
{
    public class EmailServiceFake : IEmailService
    {
        private string _body;
        private string _from = "doNotReply@becket-lee.com";

        public string Body { get { return _body; } }

        public void SendEmail(string to, string subject, string body)
        {
            _body = body;

            Console.WriteLine( $"Send Email to {to}, from: {_from}, subject: {subject}" );
            Debug.WriteLine( $"Send Email to {to}, from: {_from}, subject: {subject}" );
        }

        public Task SendEmailAsync(string to, string subject, string body)
        {
            _body = body;

            Console.WriteLine( $"Send Email to {to}, from: {_from}, subject: {subject}" );
            Debug.WriteLine( $"Send Email to {to}, from: {_from}, subject: {subject}" );

            return Task.FromResult( 0 );

        }
    }
}