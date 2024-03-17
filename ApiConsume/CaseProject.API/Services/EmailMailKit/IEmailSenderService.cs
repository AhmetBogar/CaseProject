
namespace CaseProject.API.Services.EmailMailKit
{
    public interface IEmailSenderService
    {
        Task SendEmailAsync(CreateMailDto createMailDto);
    }
}
