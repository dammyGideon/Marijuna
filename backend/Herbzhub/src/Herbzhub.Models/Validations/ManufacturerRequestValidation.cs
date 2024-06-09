using FluentValidation;
using Herbzhub.Models.Request;


namespace Herbzhub.Models.Validations
{


    public class ManufactureRequestValidator : AbstractValidator<ManufactureRequest>
    {
        public ManufactureRequestValidator()
        {
            RuleFor(x => x.roleId)
                .GreaterThan(0)
                .WithMessage("Role ID must be greater than 0.");

            RuleFor(x => x.CountiesId)
                .GreaterThan(0)
                .WithMessage("Counties ID must be greater than 0.");

            RuleFor(x => x.SerialNumber)
                .NotEmpty()
                .WithMessage("Serial number is required.");


            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("Password is required.")
                .MinimumLength(6)
                .WithMessage("Password must be at least 6 characters long.");

            RuleFor(x => x.ConfirmPassword)
                .Equal(x => x.Password)
                .WithMessage("Password and Confirm Password must match.");

            RuleFor(x => x.FirstName)
                .NotEmpty()
                .WithMessage("First name is required.");

            RuleFor(x => x.LastName)
                .NotEmpty()
                .WithMessage("Last name is required.");

            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("Email is required.")
                .EmailAddress()
                .WithMessage("Invalid email address.");

            RuleFor(x => x.PhoneNumber)
                .NotEmpty()
                .WithMessage("Phone number is required.");

            RuleFor(x => x.AddressRequest)
                .NotNull()
                .WithMessage("Address is required.")
                .SetValidator(new AddressRequestValidator());

            RuleFor(x => x.StateLicense)
           .NotEmpty().WithMessage("State license number is required.")
           .Matches(@"^[a-zA-Z0-9]+$")
           .WithMessage("State license number must be alphanumeric.");

            RuleFor(x => x.BusinessDetails)
                .NotNull()
                .WithMessage("Business details are required.")
                .SetValidator(new BusinessDetailsValidator());
        }
    }

}