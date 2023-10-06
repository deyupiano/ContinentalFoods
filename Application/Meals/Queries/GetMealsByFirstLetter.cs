using ContinentalFoods.Application.Models;
using Domain.Aggregates.MealAggregate;
using MediatR;

namespace ContinentalFoods.Application.Meals.Queries
{
    public class GetMealsByFirstLetter : IRequest<OperationResult<List<Meal>>>
    {
        public string Letter { get; set; }
    }
}
