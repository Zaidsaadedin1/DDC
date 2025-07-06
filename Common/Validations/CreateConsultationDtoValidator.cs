using DataDrivenConsultingAPis.Common.Dtos.ConsultationDtos;
using FluentValidation;

namespace DataDrivenConsultingAPis.Infrastructure.Validators
{
    public class CreateConsultationDtoValidator : AbstractValidator<CreateConsultationDto>
    {
        public CreateConsultationDtoValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First Name is required.");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last Name is required.");
            RuleFor(x => x.Email).NotEmpty().EmailAddress().WithMessage("A valid Email is required.");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Phone number is required.");
           
            RuleFor(x => x.ServiceType).NotEmpty().WithMessage("Service Type is required.");
           
            RuleFor(x => x.TermsAccepted).Equal(true).WithMessage("You must accept the terms.");
            RuleFor(x => x.UserId).NotEmpty().WithMessage("User ID is required.");
        }
    }
}
