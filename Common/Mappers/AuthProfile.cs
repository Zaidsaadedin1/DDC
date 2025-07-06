using AutoMapper;
using DataDrivenConsultingAPis.Common.Dtos.AuthDtos;
using DataDrivenConsultingAPis.Common.Entities;

namespace DataDrivenConsultingAPis.Common.Mappers
{
    public class AuthProfile : Profile
    {

        public AuthProfile()
        {
            CreateMap<LoginUserDto, User>();

            CreateMap<RegisterUserDto, User>();

        }
    }

}

