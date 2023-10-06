namespace ContinentalFoods.WebApi.Contracts.Ingredients.Requests;

public class IngredientCreate
{
    [Required]
    public string StrIngredient { get; set; }
    [Required]
    public string StrDescription { get; set; }
}