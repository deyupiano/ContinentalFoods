namespace ContinentalFoods.WebApi.Contracts.Identity
{
    public class RefreshToken
    {
        [Required]
        public string Token { get; set; }
    }
}
