

using ContinentalFoods.Application.Enums;
using ContinentalFoods.Application.Meals.Commands;
using ContinentalFoods.Application.Models;
using ContinentalFoods.Domain.Exceptions;
using DataAccessLayer;
using Domain.Aggregates.MealAggregate;
using MediatR;


namespace ContinentalFoods.Application.Meals.CommandHandlers;

public class CreateMealHandler : IRequestHandler<CreateMeal, OperationResult<Meal>>
{
    private readonly DataContext _ctx;

    public CreateMealHandler(DataContext ctx)
    {
        _ctx = ctx;
    }
    
    public async Task<OperationResult<Meal>> Handle(CreateMeal request, CancellationToken cancellationToken)
    {
        var result = new OperationResult<Meal>();
        try
        {
            var meal = Meal.CreateMeal(
            request.IdentityId,
            request.StrMeal,
            request.StrCategory,
            request.StrArea,
            request.StrInstructions,
            request.StrMealThumb,
            request.StrTags,
            request.StrYoutube,
            request.StrIngredient1,
            request.StrIngredient2,
            request.StrIngredient3,
            request.StrIngredient4,
            request.StrIngredient5,
            request.StrIngredient6,
            request.StrIngredient7,
            request.StrIngredient8,
            request.StrIngredient9,
            request.StrIngredient10,
            request.StrIngredient11,
            request.StrIngredient12,
            request.StrIngredient13,
            request.StrIngredient14,
            request.StrIngredient15,
            request.StrIngredient16,
            request.StrIngredient17,
            request.StrIngredient18,
            request.StrIngredient19,
            request.StrIngredient20,
            request.StrIngredient21,
            request.StrIngredient22,
            request.StrIngredient23,
            request.StrIngredient24,
            request.StrIngredient25,
            request.StrIngredient26,
            request.StrIngredient27,
            request.StrIngredient28,
            request.StrIngredient29,
            request.StrIngredient30,
            request.StrMeasure1,
            request.StrMeasure2,
            request.StrMeasure3,
            request.StrMeasure4,
            request.StrMeasure5,
            request.StrMeasure6,
            request.StrMeasure7,
            request.StrMeasure8,
            request.StrMeasure9,
            request.StrMeasure10,
            request.StrMeasure11,
            request.StrMeasure12,
            request.StrMeasure13,
            request.StrMeasure14,
            request.StrMeasure15,
            request.StrMeasure16,
            request.StrMeasure17,
            request.StrMeasure18,
            request.StrMeasure19,
            request.StrMeasure20,
            request.StrMeasure21,
            request.StrMeasure22,
            request.StrMeasure23,
            request.StrMeasure24,
            request.StrMeasure25,
            request.StrMeasure26,
            request.StrMeasure27,
            request.StrMeasure28,
            request.StrMeasure29,
            request.StrMeasure30);
            _ctx.Meals.Add(meal);
            await _ctx.SaveChangesAsync(cancellationToken);

            result.Payload = meal;
        }
        catch (MealInfoNotValidException e)
        {
            e.ValidationErrors.ForEach(er => result.AddError(ErrorCode.ValidationError, er));
        }

        catch (Exception e)
        {
            result.AddUnknownError(e.Message);
        }
        
        return result;
    }
}