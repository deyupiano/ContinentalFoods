using ContinentalFoods.Application.Models;
using ContinentalFoods.Application.Options;
using ContinentalFoods.Domain.Aggregates.UserProfileAggregate;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ContinentalFoods.Application.Services
{
    public class TokenGeneratorService
    {
        private readonly IdentityService _identityService;
        private readonly JwtSettings _jwtSettings;
        private readonly byte[] _key;
        public TokenGeneratorService(IdentityService identityService, IOptions<JwtSettings> jwtOptions)
        {
            _identityService = identityService;
            _jwtSettings = jwtOptions.Value;
            _key = Encoding.ASCII.GetBytes(_jwtSettings.SigningKey);
        }
        public AccessToken GenerateToken(IdentityUser identityUser, string userProfile)
        {

            DateTime expirationTime = DateTime.Now.AddMinutes(_jwtSettings.AccessTokenExpirationMinutes);
            DateTime rExpirationTime = DateTime.Now.AddMinutes(_jwtSettings.RefreshTokenExpirationMinutes);
            var claimsIdentity = new ClaimsIdentity(new Claim[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, identityUser.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, identityUser.Email),
                new Claim("IdentityId", identityUser.Id),
                new Claim("UserProfileId", userProfile),
                new Claim("AccessTokenExpirationTime", expirationTime.ToString()),
                new Claim("AccessTokenDateCreated", expirationTime.ToString()),
                new Claim("RefreshTokenExpirationMinutes", rExpirationTime.ToString())
            });
            var token = _identityService.CreateSecurityToken(claimsIdentity, "create");
            var accessToken = new AccessToken
            {
                Value = _identityService.WriteToken(token),
                ExpirationTime = expirationTime
            };
            return accessToken;
        }
        public AccessToken GenerateRefreshToken()
        {
            DateTime expirationTime = DateTime.Now.AddMinutes(_jwtSettings.AccessTokenExpirationMinutes);
            DateTime rExpirationTime = DateTime.Now.AddMinutes(_jwtSettings.RefreshTokenExpirationMinutes);
            var claimsIdentity = new ClaimsIdentity(new Claim[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, ""),
                new Claim(JwtRegisteredClaimNames.Jti, ""),
                new Claim(JwtRegisteredClaimNames.Email, ""),
                new Claim("IdentityId", ""),
                new Claim("UserProfileId", ""),
                new Claim("AccessTokenExpirationTime", expirationTime.ToString()),
                new Claim("AccessTokenDateCreated", expirationTime.ToString()),
                new Claim("RefreshTokenExpirationMinutes", rExpirationTime.ToString())
            });
            var token = _identityService.CreateSecurityToken(claimsIdentity, "refresh");
            var accessToken = new AccessToken
            {
                Value = _identityService.WriteToken(token),
                ExpirationTime = expirationTime
            };
            return accessToken;
        }
        public string GenerateRefreshToken2(string secretKey, string issuer, string audience, DateTime utcExpirationTime,
            IEnumerable<Claim> claims = null)
        {
            SecurityKey key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secretKey));
            SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            JwtSecurityToken token = new JwtSecurityToken(
                issuer,
                audience,
                claims,
                DateTime.UtcNow,
                utcExpirationTime,
                credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
