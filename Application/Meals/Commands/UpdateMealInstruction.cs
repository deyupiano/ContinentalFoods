using ContinentalFoods.Application.Models;
using Domain.Aggregates.MealAggregate;
using MediatR;

namespace ContinentalFoods.Application.Meals.Commands;

public class UpdateMealInstruction : IRequest<OperationResult<Meal>>
{
    public Guid IdMeal { get; set; }
    public string Instructions { get; set; }
    public string IdentityId { get; set; }
}