using DataDrivenConsultingAPis.Common.Enums;

namespace DataDrivenConsultingAPis.Interfaces
{
    public interface IEmailService
    {
        Task<EmailResponseStatus> SendEmailToUserAsync(string toEmail, string subject, string body);
    }
}
