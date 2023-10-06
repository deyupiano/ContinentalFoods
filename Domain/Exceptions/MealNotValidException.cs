namespace ContinentalFoods.Domain.Exceptions;

public class MealNotValidException : DomainModelInvalidException
{
    internal MealNotValidException() {}
    internal MealNotValidException(string message) : base(message) {}
    internal MealNotValidException(string message, Exception inner) : base(message, inner) {}
}