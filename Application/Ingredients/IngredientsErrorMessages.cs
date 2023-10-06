namespace ContinentalFoods.Application.Ingredients;

public class IngredientsErrorMessages
{
    public const string IngredientNotFound = "No ingredient found with ID {0}";
    public const string IngredientDeleteNotPossible = "Only the owner of a ingredient can delete it";

    public const string IngredientUpdateNotPossible =
        "Meal update not possible because it's not the ingredient owner that initiates the update";

}