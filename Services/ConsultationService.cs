using AutoMapper;
using DataDrivenConsultingAPis.Common.Dtos.ConsultationDtos;
using DataDrivenConsultingAPis.Common.Dtos.Shared;
using DataDrivenConsultingAPis.Common.Entities;
using DataDrivenConsultingAPis.Interfaces;
using DataDrivenConsultingAPis.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace DataDrivenConsultingAPis.Services
{
    public class ConsultationService : IConsultationService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ConsultationService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GenericResponse<IEnumerable<GetConsultationForAdminDto>>> GetAllConsultationsAsync()
        {
            var consultations = await _context.Consultations
                .Include(a => a.User) // Include related user data
                .ToListAsync();

            var data = _mapper.Map<IEnumerable<GetConsultationForAdminDto>>(consultations);

            return new GenericResponse<IEnumerable<GetConsultationForAdminDto>>
            {
                Success = true,
                Data = data
            };
        }


        public async Task<GenericResponse<IEnumerable<GetConsultationDto>>> GetAllUserConsultationsAsync(string userId)
        {
            var consultations = await _context.Consultations
                .Where(o => o.UserId == userId)
                .ToListAsync();

            var data = _mapper.Map<IEnumerable<GetConsultationDto>>(consultations);

            return new GenericResponse<IEnumerable<GetConsultationDto>>
            {
                Success = true,
                Data = data
            };
        }

        public async Task<GenericResponse<GetConsultationDto>> GetuConsltationByIdAsync(int consltationId)
        {
            var consultation = await _context.Consultations.FirstOrDefaultAsync(c => c.Id == consltationId);
            if (consultation == null)
            {
                return new GenericResponse<GetConsultationDto>
                {
                    Success = false,
                    Message = "consultation not found"
                };
            }

            var data = _mapper.Map<GetConsultationDto>(consultation);
            return new GenericResponse<GetConsultationDto>
            {
                Success = true,
                Data = data
            };
        }

        public async Task<GenericResponse<int>> CreateConsultationAsync(CreateConsultationDto createConsultationDto)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Email == createConsultationDto.Email || u.PhoneNumber == createConsultationDto.Phone);

            if (user != null)
            {
                createConsultationDto.UserId = user.Id;
            }


            var consultation = _mapper.Map<Consultation>(createConsultationDto);

            _context.Consultations.Add(consultation);
            await _context.SaveChangesAsync();

            return new GenericResponse<int>
            {
                Success = true,
                Data = consultation.Id
            };
        }
    }
}
