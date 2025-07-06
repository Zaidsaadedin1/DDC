using DataDrivenConsultingAPis.Common.Dtos.Shared;
using DataDrivenConsultingAPis.Common.Dtos.VerificationsDtos;
using DataDrivenConsultingAPis.Common.Enums;

namespace DataDrivenConsultingAPis.Interfaces
{
    public interface IOtpService
    {
        Task<GenericResponse<bool>> SendOtpAsync(string emailOrPhone);
        Task<VerificationResult> VerifyUserOtpAsync(VerifyOtpDto verifyOtpDto);
    }
}
