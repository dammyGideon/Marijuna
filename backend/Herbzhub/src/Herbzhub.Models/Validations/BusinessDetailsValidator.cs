using FluentValidation;
using Herbzhub.Models.Request;


namespace Herbzhub.Models.Validations
{
    public class BusinessDetailsValidator : AbstractValidator<BusinessDetails>
    {
        public BusinessDetailsValidator()
        {
            RuleFor(x => x.BusinessName)
            .NotEmpty()
            .WithMessage("Business name is required.");

            RuleFor(x => x.BusinessEIN)
            .NotEmpty().WithMessage("Business EIN is required.")
            .Matches(@"^\d{2}-\d{7}$")
            .WithMessage("Business EIN must be in the format 'XX-XXXXXXX'.");

            RuleFor(x => x.BusinessEmail)
                .NotEmpty()
                .WithMessage("Business email is required.")
                .EmailAddress()
                .WithMessage("Invalid email address.");


          RuleFor(x => x.BusinessContact)
         .NotEmpty()
         .WithMessage("Business contact is required.");

            RuleFor(x => x.BusinessAddress)
                .NotEmpty()
                .WithMessage("Business address is required.");

            RuleFor(x => x.BusinessCity)
                .GreaterThan(0)
                .WithMessage("City ID must be greater than 0.");

            RuleFor(x => x.BusinessState)
            .GreaterThan(0)
            .WithMessage("State ID must be greater than 0.");

            RuleFor(x => x.BusinessZipCode)
                .NotEmpty()
                .WithMessage("Business zip code is required.")
                .Matches(@"^\d{5}(-\d{4})?$")
                .WithMessage("Invalid zip code format.");

        }
    }

}