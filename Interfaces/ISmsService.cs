using DataDrivenConsultingAPis.Common.Enums;

namespace DataDrivenConsultingAPis.Interfaces
{
    public interface ISmsService
    {
        Task<SmsResponseStatus> SendSmsToUserAsync(string phoneNumber, string message, string otp);
    }
}
