namespace ContinentalFoods.Domain.Exceptions;

public class RefreshTokenNotValidException : DomainModelInvalidException
{
    internal RefreshTokenNotValidException() {}
    internal RefreshTokenNotValidException(string message) : base(message) {}
    internal RefreshTokenNotValidException(string message, Exception inner) : base(message, inner) {}
}