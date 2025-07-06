using AutoMapper;
using DataDrivenConsultingAPis.Common.Dtos.UserDto;
using DataDrivenConsultingAPis.Common.Entities;

namespace DataDrivenConsultingAPis.Common.Mapping
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UpdateUserDto, User>();
            CreateMap<User, GetUserDto>();
              
        }
    }
}
