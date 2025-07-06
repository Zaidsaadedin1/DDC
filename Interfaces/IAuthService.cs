using DataDrivenConsultingAPis.Common.Dtos.AuthDtos;
using DataDrivenConsultingAPis.Common.Dtos;
using DataDrivenConsultingAPis.Common.Dtos.Shared;

namespace DataDrivenConsultingAPis.Interfaces
{
    public interface IAuthService
    {
        Task<GenericResponse<RegisterUserDto>> RegisterUserAsync(RegisterUserDto registerUserDto);
        Task<GenericResponse<string>> LoginUserAsync(LoginUserDto loginUserDto);
        Task<bool> IsUsersPhoneOrEmailTakenAsync(string identifier);
        Task<GenericResponse<bool>> UserPasswordResetAsync(ResetPasswordDto resetPasswordDto);
    }
}
