using ContinentalFoods.Application.Models;
using ContinentalFoods.Application.Options;
using ContinentalFoods.Domain.Aggregates.RefreshTokenAggregate;
using DataAccessLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Text;

namespace ContinentalFoods.Application.Services.Authenticators
{
    public class Authenticator
    {
        private readonly TokenGeneratorService _accessTokenGenerator;
        private readonly DataContext _ctx;
        private readonly JwtSettings _jwtSettings;
        private readonly byte[] _key;
        public Authenticator(TokenGeneratorService accessTokenGenerator,
            DataContext ctx, IOptions<JwtSettings> jwtOptions)
        {
            _accessTokenGenerator = accessTokenGenerator;
            _ctx = ctx;
            _jwtSettings = jwtOptions.Value;
            _key = Encoding.ASCII.GetBytes(_jwtSettings.SigningKey);
        }


        public async Task<AuthenticatedUserResponse> Authenticate(IdentityUser identityUser, string userProfile)
        {
            var accessToken = _accessTokenGenerator.GenerateToken(identityUser, userProfile);
            DateTime expirationTime = DateTime.UtcNow.AddMinutes(_jwtSettings.RefreshTokenExpirationMinutes);
            var refreshToken = _accessTokenGenerator.GenerateRefreshToken();
            if (refreshToken != null)
            {
                var refreshT = RefreshToken.CreateRefreshToken(Guid.NewGuid(), identityUser.Id, refreshToken.Value);
                _ctx.RefreshTokens.Add(refreshT);
                await _ctx.SaveChangesAsync();
            }

            return new AuthenticatedUserResponse()
            {
                AccessToken = accessToken.Value,
                AccessTokenExpirationTime = accessToken.ExpirationTime,
                RefreshToken = refreshToken.Value
            };
        }
    }
}
