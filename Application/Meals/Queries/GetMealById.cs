using ContinentalFoods.Application.Models;
using Domain.Aggregates.MealAggregate;
using MediatR;

namespace ContinentalFoods.Application.Posts.Queries;

public class GetMealById : IRequest<OperationResult<Meal>>
{
    public Guid IdMeal { get; set; }
}