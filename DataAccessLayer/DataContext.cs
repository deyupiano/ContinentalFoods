

using ContinentalFoods.Dal.Configurations;
using ContinentalFoods.Domain.Aggregates.Friendships;
using ContinentalFoods.Domain.Aggregates.IngredientAggregate;
using ContinentalFoods.Domain.Aggregates.PostAggregate;
using ContinentalFoods.Domain.Aggregates.RefreshTokenAggregate;
using ContinentalFoods.Domain.Aggregates.UserProfileAggregate;
using Domain.Aggregates.MealAggregate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<FriendRequest> FriendRequests { get; set; }
        public DbSet<Friendship> Friendships { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<BasicInfo>();
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
            base.OnModelCreating(modelBuilder);

            //modelBuilder.ApplyConfiguration(new PostCommentConfig());
            //modelBuilder.ApplyConfiguration(new PostInteractionConfig());
            //modelBuilder.ApplyConfiguration(new UserProfileConfig());
            //modelBuilder.ApplyConfiguration(new IdentityUserLoginConfig());
            //modelBuilder.ApplyConfiguration(new IdentityUserRoleConfig());
            //modelBuilder.ApplyConfiguration(new IdentityUserTokenConfig());

            modelBuilder.Entity<IdentityUser>(entity =>
            {
                entity.ToTable(name: "AspNetUsers");
            });
            modelBuilder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "AspNetRoles");
            });
            modelBuilder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable(name: "AspNetUserRoles");
            });
            modelBuilder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable(name: "AspNetUserCaims");
            });
            modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable(name: "AspNetUserLogins");
            });
            modelBuilder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable(name: "AspNetRoleClaims");
            });
            modelBuilder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable(name: "AspNetUserTokens");
            });

        }
    }
}
