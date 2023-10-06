
using AutoMapper;
using ContinentalFoods.Application.Enums;
using ContinentalFoods.Application.Identity.Commands;
using ContinentalFoods.Application.Identity.Dtos;
using ContinentalFoods.Application.Models;
using ContinentalFoods.Application.Options;
using ContinentalFoods.Application.Services;
using ContinentalFoods.Application.Services.Authenticators;
using ContinentalFoods.Domain.Aggregates.RefreshTokenAggregate;
using ContinentalFoods.Domain.Aggregates.UserProfileAggregate;
using DataAccessLayer;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ContinentalFoods.Application.Identity.Handlers;

public class LoginCommandHandler : IRequestHandler<LoginCommand, OperationResult<IdentityUserProfileDto>>
{
    private readonly DataContext _ctx;
    private readonly UserManager<IdentityUser> _userManager;
    private readonly IdentityService _identityService;
    private readonly IMapper _mapper;
    private OperationResult<IdentityUserProfileDto> _result = new();
    private readonly TokenGeneratorService _token;
    private readonly JwtSettings _jwtSettings;
    private readonly byte[] _key;
    public LoginCommandHandler(DataContext ctx, UserManager<IdentityUser> userManager, 
        IdentityService identityService, IMapper mapper, TokenGeneratorService token, IOptions<JwtSettings> jwtOptions)
    {
        _ctx = ctx;
        _userManager = userManager;
        _identityService = identityService;
        _mapper = mapper;
        _token = token;
        _jwtSettings = jwtOptions.Value;
        _key = Encoding.ASCII.GetBytes(_jwtSettings.SigningKey);
    }

    public async Task<OperationResult<IdentityUserProfileDto>> Handle(LoginCommand request, 
        CancellationToken cancellationToken)
    {
        try
        {
            var identityUser = await ValidateAndGetIdentityAsync(request);
            if (_result.IsError) return _result;

            var userProfile = await _ctx.UserProfiles
                .FirstOrDefaultAsync(up => up.IdentityId == identityUser.Id, cancellationToken:
                    cancellationToken);
            DateTime rExpirationTime = DateTime.Now.AddMinutes(_jwtSettings.RefreshTokenExpirationMinutes);
            _result.Payload = _mapper.Map<IdentityUserProfileDto>(userProfile);
            _result.Payload.UserName = identityUser.UserName;
            var tResult = _token.GenerateToken(identityUser, userProfile.UserProfileId.ToString());
            _result.Payload.Token = tResult.Value;
            _result.Payload.AccessTokenExpirationTime = tResult.ExpirationTime;
            //var rfToken = _result.Payload.RefreshToken;
            //rfToken = _token.GenerateRefreshToken(
            //    _jwtSettings.SigningKey,
            //    _jwtSettings.Issuer,
            //    _jwtSettings.Audiences[0],
            //    rExpirationTime
            //    );
            var rfToken = _token.GenerateRefreshToken();
            if (rfToken != null)
            {
                _result.Payload.RefreshToken = rfToken.Value;
                var refreshToken = RefreshToken.CreateRefreshToken(Guid.NewGuid(), identityUser.Id, rfToken.Value);
                _ctx.RefreshTokens.Add(refreshToken);
                await _ctx.SaveChangesAsync(cancellationToken);
            }

            //_result.Payload.Token = GetJwtString(identityUser, userProfile);
            return _result;

        }
        catch (Exception e)
        {
            _result.AddUnknownError(e.Message);
        }

        return _result;
    }

    private async Task<IdentityUser> ValidateAndGetIdentityAsync(LoginCommand request)
    {
        var identityUser = await _userManager.FindByEmailAsync(request.Username);
            
        if (identityUser is null)
            _result.AddError(ErrorCode.IdentityUserDoesNotExist, 
                IdentityErrorMessages.NonExistentIdentityUser);

        var validPassword = await _userManager.CheckPasswordAsync(identityUser, request.Password);

        if (!validPassword)
            _result.AddError(ErrorCode.IncorrectPassword, IdentityErrorMessages.IncorrectPassword);

        return identityUser;
    }

    //private string GetJwtString(IdentityUser identityUser, UserProfile userProfile)
    //{
    //    var claimsIdentity = new ClaimsIdentity(new Claim[]
    //    {
    //        new Claim(JwtRegisteredClaimNames.Sub, identityUser.Email),
    //        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
    //        new Claim(JwtRegisteredClaimNames.Email, identityUser.Email),
    //        new Claim("IdentityId", identityUser.Id),
    //        new Claim("UserProfileId", userProfile.UserProfileId.ToString())
    //    });

    //    var token = _identityService.CreateSecurityToken(claimsIdentity);
    //    return _identityService.WriteToken(token);
    //}
}