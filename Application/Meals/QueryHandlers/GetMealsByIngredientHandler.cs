using ContinentalFoods.Application.Meals.Queries;
using ContinentalFoods.Application.Models;
using DataAccessLayer;
using Domain.Aggregates.MealAggregate;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ContinentalFoods.Application.Meals.QueryHandlers;

public class GetMealsByIngredientHandler : IRequestHandler<GetMealsByIngredient, OperationResult<List<Meal>>>
{
    private readonly DataContext _ctx;
    public GetMealsByIngredientHandler(DataContext ctx)
    {
        _ctx = ctx;
    }
    public async Task<OperationResult<List<Meal>>> Handle(GetMealsByIngredient request, CancellationToken cancellationToken)
    {
        var result = new OperationResult<List<Meal>>();
        try
        {
            var meals = await _ctx.Meals.Where(
                x => x.StrIngredient1 == request.Ingredient
                || x.StrIngredient2 == request.Ingredient
                || x.StrIngredient3 == request.Ingredient
                || x.StrIngredient4 == request.Ingredient
                || x.StrIngredient5 == request.Ingredient
                || x.StrIngredient6 == request.Ingredient
                || x.StrIngredient7 == request.Ingredient
                || x.StrIngredient8 == request.Ingredient
                || x.StrIngredient9 == request.Ingredient
                || x.StrIngredient10 == request.Ingredient
                || x.StrIngredient11 == request.Ingredient
                || x.StrIngredient12 == request.Ingredient
                || x.StrIngredient13 == request.Ingredient
                || x.StrIngredient14 == request.Ingredient
                || x.StrIngredient15 == request.Ingredient).ToListAsync(); ;
            result.Payload = meals;
        }
        catch (Exception e)
        {
            result.AddUnknownError(e.Message);
        }

        return result;
    }
}