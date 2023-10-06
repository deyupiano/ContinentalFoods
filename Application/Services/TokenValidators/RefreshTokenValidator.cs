
using ContinentalFoods.Application.Models;
using ContinentalFoods.Application.Options;
using ContinentalFoods.Application.Services.Authenticators;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ContinentalFoods.Application.Services.TokenValidators
{
    public class RefreshTokenValidator
    {
        private readonly JwtSettings _jwtSettings;
        private readonly byte[] _key;
        public RefreshTokenValidator(IOptions<JwtSettings> jwtOptions)
        {
            _jwtSettings = jwtOptions.Value;
            _key = Encoding.ASCII.GetBytes(_jwtSettings.SigningKey);
        }
        public bool Validate(string refreshToken)
        {
            TokenValidationParameters validationParameters = new TokenValidationParameters()
            {
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_jwtSettings.RefreshTokenSecret)),
                ValidIssuer = _jwtSettings.Issuer,
                ValidAudience = _jwtSettings.Audiences[0],
                ValidateIssuerSigningKey = true,
                ValidateIssuer = true,
                ValidateAudience = true,
                ClockSkew = TimeSpan.Zero,
            };

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();

            try
            {
                tokenHandler.ValidateToken(refreshToken, validationParameters, out SecurityToken validatedToken);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public string? ValidateToken(string token)
        {
            if (token == null)
                return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_jwtSettings.RefreshTokenSecret);
            try
            {
                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);

                var jwtToken = (JwtSecurityToken)validatedToken;
                var userId = jwtToken.Claims.First(x => x.Type == "id").Value;

                // return user id from JWT token if validation successful
                return userId;
            }
            catch
            {
                // return null if validation fails
                return null;
            }
        }
        public IPrincipal getIdentity(string token)
        {
            var key = Encoding.ASCII.GetBytes(_jwtSettings.RefreshTokenSecret);
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            JwtSecurityToken jwtToken = (JwtSecurityToken)tokenHandler.ReadToken(token);
            if (jwtToken == null)
                return null;

            TokenValidationParameters parameters = new TokenValidationParameters()
            {
                RequireExpirationTime = true,
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateIssuerSigningKey = false,
                IssuerSigningKey = new SymmetricSecurityKey(key)
            };

            SecurityToken securityToken;
            ClaimsPrincipal principal = tokenHandler.ValidateToken(token, parameters, out securityToken);

            Thread.CurrentPrincipal = principal;

            return principal;

        }
    }
}
