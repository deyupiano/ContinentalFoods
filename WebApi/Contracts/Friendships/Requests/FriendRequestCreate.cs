namespace ContinentalFoods.WebApi.Contracts.Friendships.Requests;

public class FriendRequestCreate
{
    [Required]
    public Guid RequesterId { get; set; }
    
    [Required]
    public Guid ReceiverId { get; set; }
}