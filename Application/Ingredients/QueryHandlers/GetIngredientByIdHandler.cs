using ContinentalFoods.Application.Enums;
using ContinentalFoods.Application.Ingredients.Queries;
using ContinentalFoods.Application.Models;
using ContinentalFoods.Domain.Aggregates.IngredientAggregate;
using DataAccessLayer;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ContinentalFoods.Application.Ingredients.QueryHandlers;

public class GetIngredientByIdHandler : IRequestHandler<GetIngredientById, OperationResult<Ingredient>>
{
    private readonly DataContext _ctx;
    public GetIngredientByIdHandler(DataContext ctx)
    {
        _ctx = ctx;
    }
    public async Task<OperationResult<Ingredient>> Handle(GetIngredientById request, CancellationToken cancellationToken)
    {
        var result = new OperationResult<Ingredient>();
        var ingredient = await _ctx.Ingredients
            .FirstOrDefaultAsync(p => p.IdIngredient == request.IdIngredient);
            
        if (ingredient is null)
        {
            result.AddError(ErrorCode.NotFound, 
                string.Format(IngredientsErrorMessages.IngredientNotFound, request.IdIngredient));
            return result;
        }

        result.Payload = ingredient;
        return result;
    }
}