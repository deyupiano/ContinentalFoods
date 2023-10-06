using ContinentalFoods.Domain.Aggregates.RefreshTokenAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ContinentalFoods.Dal.Configurations
{
    internal class RefreshTokenConfig : IEntityTypeConfiguration<RefreshToken>
    {
        public void Configure(EntityTypeBuilder<RefreshToken> builder)
        {
            builder.HasKey(pc => pc.Id);
        }
    }
}
