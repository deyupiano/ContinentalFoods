
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ContinentalFoods.Application.Options;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace ContinentalFoods.Application.Services;

public class IdentityService
{
    private readonly JwtSettings _jwtSettings;
    private readonly SecurityKey  _key;
    private readonly SecurityKey _rkey;
    public IdentityService(IOptions<JwtSettings> jwtOptions)
    {
        _jwtSettings = jwtOptions.Value;
        _key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_jwtSettings.SigningKey));
        _rkey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_jwtSettings.RefreshTokenSecret));
    }

    public JwtSecurityTokenHandler TokenHandler = new JwtSecurityTokenHandler();

    public SecurityToken CreateSecurityToken(ClaimsIdentity identity, string action)
    {
        var tokenDescriptor = GetTokenDescriptor(identity, action);

        return TokenHandler.CreateToken(tokenDescriptor);
    }

    public string WriteToken(SecurityToken token)
    {
        return TokenHandler.WriteToken(token);
    }

    private SecurityTokenDescriptor GetTokenDescriptor(ClaimsIdentity identity, string action)
    {
        if(action == "create")
        {
            return new SecurityTokenDescriptor()
            {
                Subject = identity,
                Expires = DateTime.Now.AddMinutes(_jwtSettings.AccessTokenExpirationMinutes),
                Audience = _jwtSettings.Audiences[0],
                Issuer = _jwtSettings.Issuer,
                SigningCredentials = new SigningCredentials(_key, SecurityAlgorithms.HmacSha256)
            };
        }
        else
        {
            return new SecurityTokenDescriptor()
            {
                Subject = null,
                Expires = DateTime.Now.AddMinutes(_jwtSettings.RefreshTokenExpirationMinutes),
                Audience = _jwtSettings.Audiences[0],
                Issuer = _jwtSettings.Issuer,
                SigningCredentials  = new SigningCredentials(_rkey, SecurityAlgorithms.HmacSha256),
            };
        }
    }

}