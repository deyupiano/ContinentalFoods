namespace ContinentalFoods.WebApi.Contracts.Meals.Requests;

public class MealBasicInfoUpdate
{
    [Required]
    public string StrMeal { get; set; }
    [Required]
    public string StrCategory { get; set; }
    [Required]
    public string StrArea { get; set; }
    [Required]
    public string StrTags { get; set; }
}