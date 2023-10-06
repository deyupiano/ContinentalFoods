using ContinentalFoods.Domain.Aggregates.PostAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContinentalFoods.Dal.Configurations
{
    internal class PostInteractionConfig : IEntityTypeConfiguration<PostInteraction>
    {
        public void Configure(EntityTypeBuilder<PostInteraction> builder)
        {
            builder.HasKey(pi => pi.InteractionId);
        }
    }
}
