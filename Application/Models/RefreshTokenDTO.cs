namespace ContinentalFoods.Application.Models;

public class RefreshTokenDTO
{
    public Guid Id { get; set; }
    public string Token { get; set; }
    public string IdentityId { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime LastModified { get; set; }
}

