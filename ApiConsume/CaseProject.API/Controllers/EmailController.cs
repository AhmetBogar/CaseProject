using CaseProject.API.Services.EmailMailKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;

namespace CaseProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailSenderService _emailSenderService;

        public EmailController(IEmailSenderService emailSenderService)
        {
            _emailSenderService = emailSenderService;
        }

        [HttpPost]
        public IActionResult SendEmail(CreateMailDto createMailDto)
        {
            _emailSenderService.SendEmailAsync(createMailDto);
            return Ok();    
        }
    }
}
