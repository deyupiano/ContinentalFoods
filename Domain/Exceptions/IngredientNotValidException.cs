namespace ContinentalFoods.Domain.Exceptions;

public class IngredientNotValidException : DomainModelInvalidException
{
    internal IngredientNotValidException() {}
    internal IngredientNotValidException(string message) : base(message) {}
    internal IngredientNotValidException(string message, Exception inner) : base(message, inner) {}
}