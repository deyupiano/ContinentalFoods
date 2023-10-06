using ContinentalFoods.Application.Meals.Queries;
using ContinentalFoods.Application.Models;
using DataAccessLayer;
using Domain.Aggregates.MealAggregate;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ContinentalFoods.Application.Meals.QueryHandlers;

public class GetAllMealHandler : IRequestHandler<GetAllMeals, OperationResult<List<Meal>>>
{
    private readonly DataContext _ctx;
    public GetAllMealHandler(DataContext ctx)
    {
        _ctx = ctx;
    }
    public async Task<OperationResult<List<Meal>>> Handle(GetAllMeals request, CancellationToken cancellationToken)
    {
        var result = new OperationResult<List<Meal>>();
        try
        {
            var meals = await _ctx.Meals.ToListAsync();
            result.Payload = meals;
        }
        catch (Exception e)
        {
            result.AddUnknownError(e.Message);
        }

        return result;
    }
}