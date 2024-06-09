using FluentValidation;
using Herbzhub.Models.Request;


namespace Herbzhub.Models.Validations
{
    public class AddressRequestValidator : AbstractValidator<AddressRequest>
    {
        public AddressRequestValidator()
        {
            RuleFor(x => x.streetAddress)
            .NotEmpty()
            .WithMessage("Street address is required.");

            RuleFor(x => x.usersCity)
                .GreaterThan(0)
                .WithMessage("City ID must be greater than 0.");

            RuleFor(x => x.usersState)
                .GreaterThan(0)
                .WithMessage("State ID must be greater than 0.");

            RuleFor(x => x.userZipCode)
            .NotEmpty()
            .WithMessage("Zip code is required.")
            .Matches(@"^\d{5}(-\d{4})?$")
            .WithMessage("Invalid zip code format.");
        }
    }

}