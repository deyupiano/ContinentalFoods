
using ContinentalFoods.Domain.Aggregates.IngredientAggregate;
using FluentValidation;

namespace ContinentalFoods.Domain.Validators.IngredientValidator;

public class IngredientValidator : AbstractValidator<Ingredient>
{
    public IngredientValidator()
    {
        RuleFor(info => info.StrIngredient)
            .NotNull().WithMessage("Ingredient name is required. It is currently null")
            .MinimumLength(3).WithMessage("Ingredient name must be at least 3 characters long")
            .MaximumLength(20).WithMessage("Ingredient name can contain at most 20 characters long");
 
        RuleFor(info => info.StrDescription)
            .NotNull().WithMessage("Ingredient description instructions is required. It is currently null")
            .MinimumLength(10).WithMessage("Ingredient description instructions must be at least 10 characters long")
            .MaximumLength(1200).WithMessage("Ingredient description instructions can contain at most 1200 characters long");
       
    }
}