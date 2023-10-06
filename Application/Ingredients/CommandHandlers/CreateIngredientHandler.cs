

using ContinentalFoods.Application.Enums;
using ContinentalFoods.Application.Ingredients.Commands;
using ContinentalFoods.Application.Meals.Commands;
using ContinentalFoods.Application.Models;
using ContinentalFoods.Domain.Aggregates.IngredientAggregate;
using ContinentalFoods.Domain.Exceptions;
using DataAccessLayer;
using Domain.Aggregates.MealAggregate;
using MediatR;


namespace ContinentalFoods.Application.Meals.CommandHandlers;

public class CreateIngredientHandler : IRequestHandler<CreateIngredient, OperationResult<Ingredient>>
{
    private readonly DataContext _ctx;

    public CreateIngredientHandler(DataContext ctx)
    {
        _ctx = ctx;
    }
    
    public async Task<OperationResult<Ingredient>> Handle(CreateIngredient request, CancellationToken cancellationToken)
    {
        var result = new OperationResult<Ingredient>();
        try
        {
            var ingredient = Ingredient.CreateIngredient(
            request.StrIngredient,
            request.StrDescription);
            _ctx.Ingredients.Add(ingredient);
            await _ctx.SaveChangesAsync(cancellationToken);

            result.Payload = ingredient;
        }
        catch (IngredientNotValidException e)
        {
            e.ValidationErrors.ForEach(er => result.AddError(ErrorCode.ValidationError, er));
        }

        catch (Exception e)
        {
            result.AddUnknownError(e.Message);
        }
        
        return result;
    }
}