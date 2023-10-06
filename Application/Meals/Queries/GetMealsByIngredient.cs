using ContinentalFoods.Application.Models;
using Domain.Aggregates.MealAggregate;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinentalFoods.Application.Meals.Queries
{
    public class GetMealsByIngredient : IRequest<OperationResult<List<Meal>>>
    {
        public string Ingredient { get; set; }
    }
}
