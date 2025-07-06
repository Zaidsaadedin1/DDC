using DataDrivenConsultingAPis.Common.Dtos.ConsultationDtos;
using DataDrivenConsultingAPis.Common.Dtos.Shared;

namespace DataDrivenConsultingAPis.Interfaces
{
    public interface IConsultationService
    {
        Task<GenericResponse<IEnumerable<GetConsultationForAdminDto>>> GetAllConsultationsAsync();
        Task<GenericResponse<IEnumerable<GetConsultationDto>>> GetAllUserConsultationsAsync(string userId);
        Task<GenericResponse<GetConsultationDto>> GetuConsltationByIdAsync(int consltationId);
        Task<GenericResponse<int>> CreateConsultationAsync(CreateConsultationDto createConsultationDto);
}
    }
