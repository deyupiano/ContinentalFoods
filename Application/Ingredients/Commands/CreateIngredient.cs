
using ContinentalFoods.Application.Models;
using ContinentalFoods.Domain.Aggregates.IngredientAggregate;
using MediatR;

namespace ContinentalFoods.Application.Ingredients.Commands;

public class CreateIngredient : IRequest<OperationResult<Ingredient>>
{
    public Guid IdIngredient { get; set; } = Guid.NewGuid();
    public string? StrIngredient { get; set; }
    public string? StrDescription { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime LastModified { get; set; }
}