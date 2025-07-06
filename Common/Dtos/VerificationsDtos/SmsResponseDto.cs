using DataDrivenConsultingAPis.Common.Enums;

namespace DataDrivenConsultingAPis.Common.Dtos.VerificationsDtos
{
    public class SmsResponseDto
    {
        public SmsResponseStatus Status { get; set; }
        public string OtpCode { get; set; } = null!;
    }
}
