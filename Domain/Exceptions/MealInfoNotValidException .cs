namespace ContinentalFoods.Domain.Exceptions;

public class MealInfoNotValidException : DomainModelInvalidException
{
    internal MealInfoNotValidException() {}
    internal MealInfoNotValidException(string message) : base(message) {}
    internal MealInfoNotValidException(string message, Exception inner) : base(message, inner) {}
}