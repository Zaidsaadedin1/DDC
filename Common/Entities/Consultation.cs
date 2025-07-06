using DataDrivenConsultingAPis.Common.Enums;

namespace DataDrivenConsultingAPis.Common.Entities
{
    public class Consultation
    {
        public int Id { get; set; }

        // Client Information
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;

        // Consultation Details
        public string ServiceType { get; set; } = null!;
        public string? PropertyType { get; set; } // Was: BusinessType
        public DateTime PreferredDate { get; set; }
        public string PreferredTime { get; set; } = null!;
        public string ProjectDetails { get; set; } = null!; // Was: BusinessNeeds
        public bool TermsAccepted { get; set; }
        public ConsultationStatus Status { get; set; } = ConsultationStatus.Pending;

        // Relationship to User
        public string? UserId { get; set; }
        public User? User { get; set; }

        // Timestamps
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
    }
}
