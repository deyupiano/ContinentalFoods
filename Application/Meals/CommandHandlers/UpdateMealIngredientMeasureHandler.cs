
using ContinentalFoods.Application.Enums;
using ContinentalFoods.Application.Meals.Commands;
using ContinentalFoods.Application.Models;
using ContinentalFoods.Domain.Exceptions;
using DataAccessLayer;
using Domain.Aggregates.MealAggregate;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ContinentalFoods.Application.Meals.CommandHandlers;

public class UpdateMealIngredientMeasureHandler : IRequestHandler<UpdateMealIngredientMeasure, OperationResult<Meal>>
{
    private readonly DataContext _ctx;

    public UpdateMealIngredientMeasureHandler(DataContext ctx)
    {
        _ctx = ctx;
    }
    
    public async Task<OperationResult<Meal>> Handle(UpdateMealIngredientMeasure request, CancellationToken cancellationToken)
    {
        var result = new OperationResult<Meal>();

        try
        {
            var meal = await _ctx.Meals.FirstOrDefaultAsync(p => p.IdMeal == request.IdMeal, cancellationToken: cancellationToken);
            
            if (meal is null)
            {
                result.AddError(ErrorCode.NotFound, 
                    string.Format(IngredientsErrorMessages.MealNotFound, request.IdMeal));
                return result;
            }

            if (meal.IdentityId != request.IdentityId)
            {
                result.AddError(ErrorCode.MealUpdateNotPossible, IngredientsErrorMessages.MealUpdateNotPossible);
                return result;
            }
            
            meal.UpdateMealIngredientsMeasure(
                request.IdMeal,
                request.IdentityId,
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

            await _ctx.SaveChangesAsync(cancellationToken);

            result.Payload = meal;
        }
        
        catch (MealNotValidException e)
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