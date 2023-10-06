namespace ContinentalFoods.WebApi.Contracts.Common;

public class ErrorResponses
{
    public IEnumerable<string> ErrorMessages { get; set; }

    public ErrorResponses() : this(new List<string>()) { }

    public ErrorResponses(string errorMessage) : this(new List<string>() { errorMessage }) { }

    public ErrorResponses(IEnumerable<string> errorMessages)
    {
        ErrorMessages = errorMessages;
    }
}