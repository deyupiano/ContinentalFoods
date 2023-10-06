namespace ContinentalFoods.WebApi.Contracts.Posts.Requests;

public class PostInteractionCreate
{
    [Required]
    public InteractionType Type { get; set; }
}