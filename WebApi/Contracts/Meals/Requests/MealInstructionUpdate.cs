namespace ContinentalFoods.WebApi.Contracts.Posts.Requests;

public class MealInstructionUpdate
{
    [Required]
    public string Instructions { get; set; }
}