
using Domain.Aggregates.MealAggregate;
using FluentValidation;

namespace ContinentalFoods.Domain.Validators.MealInfoValidator;

public class MealInfoValidator : AbstractValidator<Meal>
{
    public MealInfoValidator()
    {
        RuleFor(info => info.StrMeal)
            .NotNull().WithMessage("Meal name is required. It is currently null")
            .MinimumLength(3).WithMessage("Meal name must be at least 3 characters long")
            .MaximumLength(20).WithMessage("Meal name can contain at most 20 characters long");
        RuleFor(info => info.StrCategory)
            .NotNull().WithMessage("Meal category is required. It is currently null")
            .MinimumLength(3).WithMessage("Meal category must be at least 3 characters long")
            .MaximumLength(20).WithMessage("Meal category can contain at most 20 characters long");
        RuleFor(info => info.StrArea)
            .NotNull().WithMessage("Meal geographical area is required. It is currently null")
            .MinimumLength(3).WithMessage("Meal geographical area must be at least 3 characters long")
            .MaximumLength(20).WithMessage("Meal geographical area can contain at most 20 characters long");
        RuleFor(info => info.StrInstructions)
            .NotNull().WithMessage("Meal preparation instructions is required. It is currently null")
            .MinimumLength(20).WithMessage("Meal preparation instructions must be at least 20 characters long")
            .MaximumLength(1200).WithMessage("Meal preparation instructions can contain at most 1200 characters long");
        RuleFor(info => info.StrMealThumb)
            .NotNull().WithMessage("Meal image url is required. It is currently null")
            .MinimumLength(10).WithMessage("Meal image url must be at least 10 characters long")
            .MaximumLength(100).WithMessage("Meal image url can contain at most 100 characters long");
        RuleFor(info => info.StrTags)
            .MinimumLength(3).WithMessage("Meal key words must be at least 3 characters long")
            .MaximumLength(50).WithMessage("Meal key words can contain at most 100 characters long");
        RuleFor(info => info.StrYoutube)
            .NotNull().WithMessage("Meal video link is required. It is currently null")
            .MaximumLength(250).WithMessage("Meal video link can contain at most 250 characters long");
        RuleFor(info => info.StrIngredient1)
            .MaximumLength(25).WithMessage("Meal ingredient 1 can contain at most 25 characters long");
        RuleFor(info => info.StrMeasure1)
            .MaximumLength(25).WithMessage("ingredient 1 quantity can contain at most 25 characters long");
        RuleFor(info => info.StrIngredient2)
            .MaximumLength(25).WithMessage("Meal ingredient 2 can contain at most 25 characters long");
        RuleFor(info => info.StrMeasure2)
            .MaximumLength(25).WithMessage("ingredient 2 quantity can contain at most 25 characters long");
        RuleFor(info => info.StrIngredient3)
            .MaximumLength(25).WithMessage("Meal ingredient 3 can contain at most 25 characters long");
        RuleFor(info => info.StrMeasure3)
            .MaximumLength(25).WithMessage("ingredient 3 quantity can contain at most 25 characters long");
        RuleFor(info => info.StrIngredient4)
            .MaximumLength(25).WithMessage("Meal ingredient 4 can contain at most 25 characters long");
        RuleFor(info => info.StrMeasure4)
            .MaximumLength(25).WithMessage("ingredient 4 quantity can contain at most 25 characters long");
        RuleFor(info => info.StrIngredient5)
            .MaximumLength(25).WithMessage("Meal ingredient 5 can contain at most 25 characters long");
        RuleFor(info => info.StrMeasure5)
            .MaximumLength(25).WithMessage("ingredient 5 quantity can contain at most 25 characters long");
        RuleFor(info => info.StrIngredient6)
            .MaximumLength(25).WithMessage("Meal ingredient 6 can contain at most 25 characters long");
        RuleFor(info => info.StrMeasure6)
            .MaximumLength(25).WithMessage("ingredient 6 quantity can contain at most 25 characters long");
        RuleFor(info => info.StrIngredient7)
            .MaximumLength(25).WithMessage("Meal ingredient 7 can contain at most 25 characters long");
        RuleFor(info => info.StrMeasure7)
            .MaximumLength(25).WithMessage("ingredient 7 quantity can contain at most 25 characters long");
        RuleFor(info => info.StrIngredient8)
            .MaximumLength(25).WithMessage("Meal ingredient 8 can contain at most 25 characters long");
        RuleFor(info => info.StrMeasure8)
            .MaximumLength(25).WithMessage("ingredient 8 quantity can contain at most 25 characters long");
        RuleFor(info => info.StrIngredient9)
            .MaximumLength(25).WithMessage("Meal ingredient 9 can contain at most 25 characters long");
        RuleFor(info => info.StrMeasure9)
            .MaximumLength(25).WithMessage("ingredient 9 quantity can contain at most 25 characters long");
        RuleFor(info => info.StrIngredient10)
            .MaximumLength(25).WithMessage("Meal ingredient 10 can contain at most 25 characters long");
        RuleFor(info => info.StrMeasure10)
            .MaximumLength(25).WithMessage("ingredient 10 quantity can contain at most 25 characters long");
        RuleFor(info => info.StrIngredient11)
            .MaximumLength(25).WithMessage("Meal ingredient 11 can contain at most 25 characters long");
        RuleFor(info => info.StrMeasure11)
            .MaximumLength(25).WithMessage("ingredient 11 quantity can contain at most 25 characters long");
        RuleFor(info => info.StrIngredient12)
            .MaximumLength(25).WithMessage("Meal ingredient 12 can contain at most 25 characters long");
        RuleFor(info => info.StrMeasure12)
            .MaximumLength(25).WithMessage("ingredient 12 quantity can contain at most 25 characters long");
        RuleFor(info => info.StrIngredient13)
            .MaximumLength(25).WithMessage("Meal ingredient 13 can contain at most 25 characters long");
        RuleFor(info => info.StrMeasure13)
            .MaximumLength(25).WithMessage("ingredient 13 quantity can contain at most 25 characters long");
        RuleFor(info => info.StrIngredient14)
            .MaximumLength(25).WithMessage("Meal ingredient 14 can contain at most 25 characters long");
        RuleFor(info => info.StrMeasure14)
            .MaximumLength(25).WithMessage("ingredient 14 quantity can contain at most 25 characters long");
        RuleFor(info => info.StrIngredient15)
            .MaximumLength(25).WithMessage("Meal ingredient 15 can contain at most 25 characters long");
        RuleFor(info => info.StrMeasure15)
            .MaximumLength(25).WithMessage("ingredient 15 quantity can contain at most 25 characters long");
        RuleFor(info => info.StrIngredient16)
            .MaximumLength(25).WithMessage("Meal ingredient 16 can contain at most 25 characters long");
        RuleFor(info => info.StrMeasure16)
            .MaximumLength(25).WithMessage("ingredient 16 quantity can contain at most 25 characters long");
        RuleFor(info => info.StrIngredient17)
            .MaximumLength(25).WithMessage("Meal ingredient 17 can contain at most 25 characters long");
        RuleFor(info => info.StrMeasure17)
            .MaximumLength(25).WithMessage("ingredient 17 quantity can contain at most 25 characters long");
        RuleFor(info => info.StrIngredient18)
            .MaximumLength(25).WithMessage("Meal ingredient 18 can contain at most 25 characters long");
        RuleFor(info => info.StrMeasure18)
            .MaximumLength(25).WithMessage("ingredient 18 quantity can contain at most 25 characters long");
        RuleFor(info => info.StrIngredient19)
            .MaximumLength(25).WithMessage("Meal ingredient 19 can contain at most 25 characters long");
        RuleFor(info => info.StrMeasure19)
            .MaximumLength(25).WithMessage("ingredient 19 quantity can contain at most 25 characters long");
        RuleFor(info => info.StrIngredient20)
            .MaximumLength(25).WithMessage("Meal ingredient 20 can contain at most 25 characters long");
        RuleFor(info => info.StrMeasure20)
            .MaximumLength(25).WithMessage("ingredient 20 quantity can contain at most 25 characters long");
        RuleFor(info => info.StrIngredient21)
            .MaximumLength(25).WithMessage("Meal ingredient 21 can contain at most 25 characters long");
        RuleFor(info => info.StrMeasure21)
            .MaximumLength(25).WithMessage("ingredient 21 quantity can contain at most 25 characters long");
        RuleFor(info => info.StrIngredient22)
            .MaximumLength(25).WithMessage("Meal ingredient 22 can contain at most 25 characters long");
        RuleFor(info => info.StrMeasure22)
            .MaximumLength(25).WithMessage("ingredient 22 quantity can contain at most 25 characters long");
        RuleFor(info => info.StrIngredient23)
            .MaximumLength(25).WithMessage("Meal ingredient 23 can contain at most 25 characters long");
        RuleFor(info => info.StrMeasure23)
            .MaximumLength(25).WithMessage("ingredient 23 quantity can contain at most 25 characters long");
        RuleFor(info => info.StrIngredient24)
            .MaximumLength(25).WithMessage("Meal ingredient 24 can contain at most 25 characters long");
        RuleFor(info => info.StrMeasure24)
            .MaximumLength(25).WithMessage("ingredient 24 quantity can contain at most 25 characters long");
        RuleFor(info => info.StrIngredient25)
            .MaximumLength(25).WithMessage("Meal ingredient 25 can contain at most 25 characters long");
        RuleFor(info => info.StrMeasure25)
            .MaximumLength(25).WithMessage("ingredient 25 quantity can contain at most 25 characters long");
        RuleFor(info => info.StrIngredient26)
            .MaximumLength(25).WithMessage("Meal ingredient 26 can contain at most 25 characters long");
        RuleFor(info => info.StrMeasure26)
            .MaximumLength(25).WithMessage("ingredient 26 quantity can contain at most 25 characters long");
        RuleFor(info => info.StrIngredient27)
            .MaximumLength(25).WithMessage("Meal ingredient 27 can contain at most 25 characters long");
        RuleFor(info => info.StrMeasure27)
            .MaximumLength(25).WithMessage("ingredient 27 quantity can contain at most 25 characters long");
        RuleFor(info => info.StrIngredient28)
            .MaximumLength(25).WithMessage("Meal ingredient 28 can contain at most 25 characters long");
        RuleFor(info => info.StrMeasure28)
            .MaximumLength(25).WithMessage("ingredient 28 quantity can contain at most 25 characters long");
        RuleFor(info => info.StrIngredient29)
            .MaximumLength(25).WithMessage("Meal ingredient 29 can contain at most 25 characters long");
        RuleFor(info => info.StrMeasure29)
            .MaximumLength(25).WithMessage("ingredient 29 quantity can contain at most 25 characters long");
        RuleFor(info => info.StrIngredient30)
            .MaximumLength(25).WithMessage("Meal ingredient 30 can contain at most 25 characters long");
        RuleFor(info => info.StrMeasure30)
            .MaximumLength(25).WithMessage("ingredient 30 quantity can contain at most 25 characters long");
    }
}