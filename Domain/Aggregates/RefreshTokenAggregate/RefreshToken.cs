using ContinentalFoods.Domain.Aggregates.PostAggregate;
using Microsoft.VisualBasic;
using System.Xml.Linq;

namespace ContinentalFoods.Domain.Aggregates.RefreshTokenAggregate
{
    public class RefreshToken
    {
        private RefreshToken()
        {
        }
        public Guid Id { get; private set; }
        public string IdentityId { get; private set; }
        public string Token { get; private set; }
        public DateTime DateCreated { get; private set; }
        public DateTime LastModified { get; private set; }

        // Factory method
        public static RefreshToken CreateRefreshToken(Guid id, string identityId, string token)
        {
            return new RefreshToken
            {
                Id = id,
                IdentityId = identityId,
                Token = token,
                DateCreated = DateTime.UtcNow,
                LastModified = DateTime.UtcNow
            };    
        }

        //public methods

        public void UpdateRefreshToken(string identityId, string token)
        {
            IdentityId = identityId;
            Token = token;
            LastModified = DateTime.UtcNow;
        }

    }
}
