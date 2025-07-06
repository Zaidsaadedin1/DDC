using AutoMapper;
using DataDrivenConsultingAPis.Common.Dtos.ConsultationDtos;
using DataDrivenConsultingAPis.Common.Entities;

public class ConsultationMappingProfile : Profile
{
    public ConsultationMappingProfile()
    {
        CreateMap<Consultation, GetConsultationDto>();

        CreateMap<CreateConsultationDto, Consultation>();

        CreateMap<Consultation, GetConsultationForAdminDto>()
    .ForMember(dest => dest.UserFirstName, opt => opt.MapFrom(src => src.User != null ? src.User.FirstName : null))
    .ForMember(dest => dest.UserLastName, opt => opt.MapFrom(src => src.User != null ? src.User.LastName : null))
    .ForMember(dest => dest.UserEmail, opt => opt.MapFrom(src => src.User != null ? src.User.Email : null))
    .ForMember(dest => dest.UserPhone, opt => opt.MapFrom(src => src.User != null ? src.User.PhoneNumber : null));

    }
}
