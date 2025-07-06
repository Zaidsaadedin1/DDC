using DataDrivenConsultingAPis.Common.Dtos.ConsultationDtos;
using DataDrivenConsultingAPis.Common.Dtos.Shared;
using DataDrivenConsultingAPis.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace DataDrivenConsultingAPis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultationController : ControllerBase
    {
        private readonly IConsultationService _consultationService;

        public ConsultationController(IConsultationService consultationService)
        {
            _consultationService = consultationService;
        }
        [HttpGet]
        public async Task<ActionResult<GenericResponse<IEnumerable<GetConsultationDto>>>> GetConsultations()
        {
            var response = await _consultationService.GetAllConsultationsAsync();
            return Ok(response);
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<GenericResponse<GetConsultationDto>>> GetConsultation(int consltationId)
        {
            var response = await _consultationService.GetuConsltationByIdAsync(consltationId);
            if (!response.Success)
                return NotFound(response);
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<GenericResponse<int>>> CreateConsultation([FromBody] CreateConsultationDto CreateConsultationDto)
        {
            var response = await _consultationService.CreateConsultationAsync(CreateConsultationDto);
            return Ok(response);
        }

        [HttpGet("GetAllUserAppointmentAsync/{id}")]
        public async Task<ActionResult<GenericResponse<IEnumerable<GetConsultationDto>>>> GetAllUserAppointmentAsync(string id)
        {
            var response = await _consultationService.GetAllUserConsultationsAsync(id);
            return Ok(response);
        }
    }
}
