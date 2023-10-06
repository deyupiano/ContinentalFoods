using ContinentalFoods.Domain.Aggregates.PostAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ContinentalFoods.Dal.Configurations
{
    internal class PostCommentConfig : IEntityTypeConfiguration<PostComment>
    {
        public void Configure(EntityTypeBuilder<PostComment> builder)
        {
            builder.HasKey(pc => pc.CommentId);
        }
    }
}
