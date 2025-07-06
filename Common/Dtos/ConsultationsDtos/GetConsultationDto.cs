using DataDrivenConsultingAPis.Common.Enums;

namespace DataDrivenConsultingAPis.Common.Dtos.ConsultationDtos
{
    public class GetConsultationDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string ServiceType { get; set; } = string.Empty;
        public string BusinessType { get; set; } = string.Empty;
        public string PreferredDate { get; set; } = string.Empty;
        public string PreferredTime { get; set; } = string.Empty;
        public string BusinessNeeds { get; set; } = string.Empty;
        public bool TermsAccepted { get; set; }
        public string? UserId { get; set; }
        public string Status { get; set; } = string.Empty;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}