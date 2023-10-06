using ContinentalFoods.Application.Models;
using Domain.Aggregates.MealAggregate;
using MediatR;

namespace ContinentalFoods.Application.Meals.Commands;

public class UpdateMealBasicInfo : IRequest<OperationResult<Meal>>
{
    public Guid IdMeal { get; set; }
    public string IdentityId { get; set; }
    public string? StrMeal { get; set; }
    public string? StrCategory { get; set; }
    public string? StrArea { get; set; }
    public string? StrTags { get; set; }
}