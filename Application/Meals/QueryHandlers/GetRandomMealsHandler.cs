using ContinentalFoods.Application.Meals.Queries;
using ContinentalFoods.Application.Models;
using DataAccessLayer;
using Domain.Aggregates.MealAggregate;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ContinentalFoods.Application.Meals.QueryHandlers;

public class GetRandomMealsHandler : IRequestHandler<GetRandomMeals, OperationResult<List<Meal>>>
{
    private readonly DataContext _ctx;
    public GetRandomMealsHandler(DataContext ctx)
    {
        _ctx = ctx;
    }
    public async Task<OperationResult<List<Meal>>> Handle(GetRandomMeals request, CancellationToken cancellationToken)
    {
        var result = new OperationResult<List<Meal>>();
        try
        {
            var meals = await _ctx.Meals.OrderBy(x => Guid.NewGuid()).Take(10).ToListAsync();
            result.Payload = meals;
        }
        catch (Exception e)
        {
            result.AddUnknownError(e.Message);
        }

        return result;
    }
}