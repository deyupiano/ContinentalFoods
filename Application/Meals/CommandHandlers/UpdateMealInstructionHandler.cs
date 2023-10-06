
using ContinentalFoods.Application.Enums;
using ContinentalFoods.Application.Meals.Commands;
using ContinentalFoods.Application.Models;
using ContinentalFoods.Domain.Exceptions;
using DataAccessLayer;
using Domain.Aggregates.MealAggregate;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ContinentalFoods.Application.Meals.CommandHandlers;

public class UpdateMealInstructionHandler : IRequestHandler<UpdateMealInstruction, OperationResult<Meal>>
{
    private readonly DataContext _ctx;

    public UpdateMealInstructionHandler(DataContext ctx)
    {
        _ctx = ctx;
    }
    
    public async Task<OperationResult<Meal>> Handle(UpdateMealInstruction request, CancellationToken cancellationToken)
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
            
            meal.UpdateMealInstruction(request.IdMeal, request.IdentityId, request.Instructions);

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