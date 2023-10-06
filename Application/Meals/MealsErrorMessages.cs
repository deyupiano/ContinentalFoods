namespace ContinentalFoods.Application.Meals;

public class IngredientsErrorMessages
{
    public const string MealNotFound = "No meal found with ID {0}";
    public const string MealDeleteNotPossible = "Only the owner of a meal can delete it";

    public const string MealUpdateNotPossible =
        "Meal update not possible because it's not the meal owner that initiates the update";

}