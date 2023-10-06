namespace ContinentalFoods.WebApi.Contracts.Identity
{
    public class DeleteToken
    {
        [Required]
        public Guid Id { get; set; }
    }
}
