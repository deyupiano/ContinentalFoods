using ContinentalFoods.Application.Models;
using ContinentalFoods.Domain.Aggregates.IngredientAggregate;
using MediatR;

namespace ContinentalFoods.Application.Ingredients.Commands;

public class UpdateIngredient : IRequest<OperationResult<Ingredient>>
{
    public Guid IdIngredient { get; set; }
    public string? StrIngredient { get; set; }
    public string? StrDescription { get; set; }
}