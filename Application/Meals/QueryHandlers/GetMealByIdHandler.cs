using ContinentalFoods.Application.Enums;
using ContinentalFoods.Application.Models;
using ContinentalFoods.Application.Posts.Queries;
using DataAccessLayer;
using Domain.Aggregates.MealAggregate;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ContinentalFoods.Application.Meals.QueryHandlers;

public class GetMealByIdHandler : IRequestHandler<GetMealById, OperationResult<Meal>>
{
    private readonly DataContext _ctx;
    public GetMealByIdHandler(DataContext ctx)
    {
        _ctx = ctx;
    }
    public async Task<OperationResult<Meal>> Handle(GetMealById request, CancellationToken cancellationToken)
    {
        var result = new OperationResult<Meal>();
        var meal = await _ctx.Meals
            .FirstOrDefaultAsync(p => p.IdMeal == request.IdMeal);
            
        if (meal is null)
        {
            result.AddError(ErrorCode.NotFound, 
                string.Format(IngredientsErrorMessages.MealNotFound, request.IdMeal));
            return result;
        }

        result.Payload = meal;
        return result;
    }
}