using ContinentalFoods.Application.Models;
using ContinentalFoods.Domain.Aggregates.IngredientAggregate;
using MediatR;

namespace ContinentalFoods.Application.Ingredients.Queries;

public class GetIngredientById : IRequest<OperationResult<Ingredient>>
{
    public Guid IdIngredient { get; set; }
}