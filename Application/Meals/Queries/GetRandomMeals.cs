using ContinentalFoods.Application.Models;
using Domain.Aggregates.MealAggregate;
using MediatR;

namespace ContinentalFoods.Application.Meals.Queries
{
    public class GetRandomMeals : IRequest<OperationResult<List<Meal>>>
    {
    }
}
