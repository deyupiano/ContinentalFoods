using ContinentalFoods.Application.Ingredients.Queries;
using ContinentalFoods.Application.Models;
using ContinentalFoods.Domain.Aggregates.IngredientAggregate;
using DataAccessLayer;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ContinentalFoods.Application.Ingredients.QueryHandlers;

public class GetAllIngredientsHandler : IRequestHandler<GetAllIngredients, OperationResult<List<Ingredient>>>
{
    private readonly DataContext _ctx;
    public GetAllIngredientsHandler(DataContext ctx)
    {
        _ctx = ctx;
    }
    public async Task<OperationResult<List<Ingredient>>> Handle(GetAllIngredients request, CancellationToken cancellationToken)
    {
        var result = new OperationResult<List<Ingredient>>();
        try
        {
            var ingredients = await _ctx.Ingredients.ToListAsync();
            result.Payload = ingredients;
        }
        catch (Exception e)
        {
            result.AddUnknownError(e.Message);
        }

        return result;
    }
}