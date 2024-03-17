using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using Org.BouncyCastle.Security;

namespace CaseProject.API.Services.EmailMailKit
{
    public class EmailSenderService:IEmailSenderService
    {
        private readonly IConfiguration _config;

        public EmailSenderService(IConfiguration config)
        {
            _config = config;
        }

        public Task SendEmailAsync(CreateMailDto createMailDto)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("egeriatestmail@gmail.com"));
            email.To.Add(MailboxAddress.Parse(createMailDto.To));
            email.Subject = createMailDto.Subject;
            email.Body = new TextPart(TextFormat.Html) { Text = createMailDto.Body };

            using var smtp = new SmtpClient();
            smtp.Connect(_config.GetSection("EmailHost").Value, 587, false);
            smtp.Authenticate(_config.GetSection("EmailUsername").Value, _config.GetSection("EmailPassword").Value);
            smtp.Send(email);
            smtp.Disconnect(true);

            return Task.CompletedTask;
        }
    }
}
