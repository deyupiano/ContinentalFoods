using ContinentalFoods.Domain.Aggregates.PostAggregate;
using Domain.Aggregates.MealAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ContinentalFoods.Dal.Configurations
{
    internal class MealConfig : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder.HasKey(pc => pc.IdMeal);
        }
    }
}
