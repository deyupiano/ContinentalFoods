using ContinentalFoods.Domain.Aggregates.IngredientAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ContinentalFoods.Dal.Configurations
{
    internal class IngredientConfig : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            builder.HasKey(pc => pc.IdIngredient);
        }
    }
}
