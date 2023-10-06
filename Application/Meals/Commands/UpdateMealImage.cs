using ContinentalFoods.Application.Models;
using Domain.Aggregates.MealAggregate;
using MediatR;

namespace ContinentalFoods.Application.Meals.Commands;

public class UpdateMealImage : IRequest<OperationResult<Meal>>
{
    public Guid IdMeal { get; set; }
    public string? StrMealThumb { get; set; }
    public string IdentityId { get; set; }
}