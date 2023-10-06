using ContinentalFoods.Application.Meals.Queries;
using ContinentalFoods.Application.Models;
using DataAccessLayer;
using Domain.Aggregates.MealAggregate;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ContinentalFoods.Application.Meals.QueryHandlers;

public class GetMealsByFirstLetterHandler : IRequestHandler<GetMealsByFirstLetter, OperationResult<List<Meal>>>
{
    private readonly DataContext _ctx;
    public GetMealsByFirstLetterHandler(DataContext ctx)
    {
        _ctx = ctx;
    }
    public async Task<OperationResult<List<Meal>>> Handle(GetMealsByFirstLetter request, CancellationToken cancellationToken)
    {
        var result = new OperationResult<List<Meal>>();
        try
        {
            var meals = await _ctx.Meals.Where(x=>x.StrMeal.StartsWith(request.Letter)).ToListAsync();
            result.Payload = meals;
        }
        catch (Exception e)
        {
            result.AddUnknownError(e.Message);
        }

        return result;
    }
}