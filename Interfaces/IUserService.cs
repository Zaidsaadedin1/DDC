using DataDrivenConsultingAPis.Common.Dtos.Shared;
using DataDrivenConsultingAPis.Common.Dtos.UserDto;

namespace DataDrivenConsultingAPis.Interfaces
{
    public interface IUserService
    {
        Task<GenericResponse<GetUserDto>> GetUserByEmailOrPhoneAsync(string emailOrPhone);
        Task<GenericResponse<GetUserDto>> GetUserByIdAsync(string userId);
        Task<GenericResponse<IEnumerable<GetUserDto>>> GetAllUsersAsync();
        Task<GenericResponse<bool>> UpdateUserAsync(string userId, UpdateUserDto userDto);
        Task<GenericResponse<bool>> DeleteUserAsync(string userId);
    }
}
