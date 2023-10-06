
using ContinentalFoods.Application.Enums;
using ContinentalFoods.Application.Meals.Commands;
using ContinentalFoods.Application.Models;
using ContinentalFoods.Domain.Exceptions;
using DataAccessLayer;
using Domain.Aggregates.MealAggregate;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ContinentalFoods.Application.Meals.CommandHandlers;

public class UpdateMealIngredientsHandler : IRequestHandler<UpdateMealIngrdients, OperationResult<Meal>>
{
    private readonly DataContext _ctx;

    public UpdateMealIngredientsHandler(DataContext ctx)
    {
        _ctx = ctx;
    }
    
    public async Task<OperationResult<Meal>> Handle(UpdateMealIngrdients request, CancellationToken cancellationToken)
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
            
            meal.UpdateMealIngredients(
                request.IdMeal,
                request.IdentityId,
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
                request.StrIngredient30);

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