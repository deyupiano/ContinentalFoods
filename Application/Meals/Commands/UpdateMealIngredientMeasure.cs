using ContinentalFoods.Application.Models;
using Domain.Aggregates.MealAggregate;
using MediatR;

namespace ContinentalFoods.Application.Meals.Commands;

public class UpdateMealIngredientMeasure : IRequest<OperationResult<Meal>>
{
    public Guid IdMeal { get; set; }
    public string IdentityId { get; set; }
    public string? StrMeasure1 { get; set; }
    public string? StrMeasure2 { get; set; }
    public string? StrMeasure3 { get; set; }
    public string? StrMeasure4 { get; set; }
    public string? StrMeasure5 { get; set; }
    public string? StrMeasure6 { get; set; }
    public string? StrMeasure7 { get; set; }
    public string? StrMeasure8 { get; set; }
    public string? StrMeasure9 { get; set; }
    public string? StrMeasure10 { get; set; }
    public string? StrMeasure11 { get; set; }
    public string? StrMeasure12 { get; set; }
    public string? StrMeasure13 { get; set; }
    public string? StrMeasure14 { get; set; }
    public string? StrMeasure15 { get; set; }
    public string? StrMeasure16 { get; set; }
    public string? StrMeasure17 { get; set; }
    public string? StrMeasure18 { get; set; }
    public string? StrMeasure19 { get; set; }
    public string? StrMeasure20 { get; set; }
    public string? StrMeasure21 { get; set; }
    public string? StrMeasure22 { get; set; }
    public string? StrMeasure23 { get; set; }
    public string? StrMeasure24 { get; set; }
    public string? StrMeasure25 { get; set; }
    public string? StrMeasure26 { get; set; }
    public string? StrMeasure27 { get; set; }
    public string? StrMeasure28 { get; set; }
    public string? StrMeasure29 { get; set; }
    public string? StrMeasure30 { get; set; }
}