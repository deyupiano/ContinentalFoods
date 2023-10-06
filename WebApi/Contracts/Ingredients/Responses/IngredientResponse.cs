namespace ContinentalFoods.WebApi.Contracts.Ingredients.Responses;

public class IngredientResponse
{
    public Guid IdIngredient { get; set; }
    public string StrIngredient { get; set; }
    public string StrDescription { get; set; }   
    public DateTime DateCreated { get; set; }
    public DateTime LastModified { get; set; }

}