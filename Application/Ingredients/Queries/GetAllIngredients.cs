
using ContinentalFoods.Application.Models;
using ContinentalFoods.Domain.Aggregates.IngredientAggregate;
using MediatR;

namespace ContinentalFoods.Application.Ingredients.Queries;

public class GetAllIngredients : IRequest<OperationResult<List<Ingredient>>>
{
    
}