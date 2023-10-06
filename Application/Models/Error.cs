using ContinentalFoods.Application.Enums;

namespace ContinentalFoods.Application.Models;

public class Error
{
    public ErrorCode Code { get; set; }
    public string Message { get; set; }
}