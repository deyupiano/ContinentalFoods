
using ContinentalFoods.Application.Enums;
using ContinentalFoods.Application.Ingredients.Commands;
using ContinentalFoods.Application.Models;
using ContinentalFoods.Domain.Aggregates.IngredientAggregate;
using ContinentalFoods.Domain.Exceptions;
using DataAccessLayer;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ContinentalFoods.Application.Ingredients.CommandHandlers;

public class UpdateIngredientHandler : IRequestHandler<UpdateIngredient, OperationResult<Ingredient>>
{
    private readonly DataContext _ctx;

    public UpdateIngredientHandler(DataContext ctx)
    {
        _ctx = ctx;
    }
    
    public async Task<OperationResult<Ingredient>> Handle(UpdateIngredient request, CancellationToken cancellationToken)
    {
        var result = new OperationResult<Ingredient>();

        try
        {
            var ingredient = await _ctx.Ingredients.FirstOrDefaultAsync(p => p.IdIngredient == request.IdIngredient, cancellationToken: cancellationToken);
            
            if (ingredient is null)
            {
                result.AddError(ErrorCode.NotFound, 
                    string.Format(IngredientsErrorMessages.IngredientNotFound, request.IdIngredient));
                return result;
            }

            //if (post.UserProfileId != request.UserProfileId)
            //{
            //    result.AddError(ErrorCode.PostUpdateNotPossible, PostsErrorMessages.PostUpdateNotPossible);
            //    return result;
            //}

            ingredient.UpdateIngredient(request.StrIngredient, request.StrDescription);

            await _ctx.SaveChangesAsync(cancellationToken);

            result.Payload = ingredient;
        }
        
        catch (IngredientNotValidException e)
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