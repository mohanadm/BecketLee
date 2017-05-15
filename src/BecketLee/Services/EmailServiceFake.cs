using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace BecketLee.Services
{
    public class EmailServiceFake : IEmailService
    {
        private string _body;

        public string Body { get { return _body; } }

        public void SendEmail(string to, string @from, string subject, string body)
        {
            _body = body;

            Console.WriteLine( $"Send Email to {to}, from: {from}, subject: {subject}" );
            Debug.WriteLine( $"Send Email to {to}, from: {from}, subject: {subject}" );
        }
    }
}