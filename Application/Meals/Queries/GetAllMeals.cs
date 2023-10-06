
using ContinentalFoods.Application.Models;
using Domain.Aggregates.MealAggregate;
using MediatR;

namespace ContinentalFoods.Application.Meals.Queries;

public class GetAllMeals : IRequest<OperationResult<List<Meal>>>
{
    
}