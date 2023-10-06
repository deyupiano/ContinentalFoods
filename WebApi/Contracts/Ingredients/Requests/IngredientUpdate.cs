namespace ContinentalFoods.WebApi.Contracts.Ingredients.Requests;

public class IngredientUpdate
{
    [Required]
    public string StrIngredient { get; set; }
    [Required]
    public string StrDescription { get; set; }
}