using ContinentalFoods.Domain.Aggregates.RefreshTokenAggregate;
using FluentValidation;

namespace ContinentalFoods.Domain.Validators.RefreshTokenValidator;

public class RefreshTokenValidators : AbstractValidator<RefreshToken>
{
    public RefreshTokenValidators()
    {
        RuleFor(p => p.IdentityId)
            .NotNull().WithMessage("User identity can't be null")
            .NotEmpty().WithMessage("User identity can't be empty");
    }
}