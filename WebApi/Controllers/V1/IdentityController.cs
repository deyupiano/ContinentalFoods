using ContinentalFoods.Application.Meals.Queries;
using ContinentalFoods.Application.Models;
using ContinentalFoods.Application.RefreshTokens.Commands;
using ContinentalFoods.Application.RefreshTokens.Queries;
using ContinentalFoods.Application.Services.Authenticators;
using ContinentalFoods.Application.Services.TokenValidators;
using ContinentalFoods.Domain.Aggregates.RefreshTokenAggregate;
using ContinentalFoods.WebApi.Contracts.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;
using System.Threading;

namespace ContinentalFoods.WebApi.Controllers.V1;

public class IdentityController : BaseController
{
    private readonly Authenticator _authenticator;
    private readonly RefreshTokenValidator _refreshTokenValidator;
    public IdentityController(RefreshTokenValidator refreshTokenValidator, Authenticator authenticator)
    {
        _authenticator = authenticator;
        _refreshTokenValidator = refreshTokenValidator;
    }
    [HttpPost]
    [Route(ApiRoutes.Identity.Registration)]
    [ValidateModel]
    [AllowAnonymous]
    public async Task<IActionResult> Register([FromBody] UserRegistration registration, CancellationToken cancellationToken)
    {
        var command = _mapper.Map<RegisterIdentity>(registration);
        //var command = new RegisterIdentity
        //{
        //    FirstName = registration.FirstName,
        //    LastName = registration.LastName,
        //    Password = registration.Password,
        //    CurrentCity = registration.CurrentCity,
        //    DateOfBirth = registration.DateOfBirth,
        //    Phone = registration.Phone,
        //    Username = registration.Username,
        //};
        var result = await _mediator.Send(command, cancellationToken);

        if (result.IsError) return HandleErrorResponse(result.Errors);

        return Ok(_mapper.Map<IdentityUserProfile>(result.Payload));
    }

    [HttpPost]
    [Route(ApiRoutes.Identity.Login)]
    [ValidateModel]
    public async Task<IActionResult> Login(Login login, CancellationToken cancellationToken)
    {
       
        var command = _mapper.Map<LoginCommand>(login);
        var result = await _mediator.Send(command, cancellationToken);

        if (result.IsError) return HandleErrorResponse(result.Errors);

        return Ok(_mapper.Map<IdentityUserProfile>(result.Payload));
    }

    [HttpDelete]
    [Route(ApiRoutes.Identity.IdentityById)]
    [ValidateGuid("identityUserId")]
    [Authorize( AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public async Task<IActionResult> DeleteAccount(string identityUserId, CancellationToken token)
    {
        var identityUserGuid = Guid.Parse(identityUserId);
        var requestorGuid = HttpContext.GetIdentityIdClaimValue();
        var command = new RemoveAccount
        {
            IdentityUserId = identityUserGuid,
            RequestorGuid = requestorGuid
        };
        var result = await _mediator.Send(command, token);

        if (result.IsError) return HandleErrorResponse(result.Errors);
        
        return NoContent();
    }

    [HttpGet]
    [Route(ApiRoutes.Identity.CurrentUser)]
    [Authorize( AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public async Task<IActionResult> CurrentUser(CancellationToken token)
    {
        var userProfileId = HttpContext.GetUserProfileIdClaimValue();

        var query = new GetCurrentUser { UserProfileId = userProfileId, ClaimsPrincipal = HttpContext.User};
        var result = await _mediator.Send(query, token);

        if (result.IsError) return HandleErrorResponse(result.Errors);
        
        return Ok(_mapper.Map<IdentityUserProfile>(result.Payload));
    }
    [HttpPost]
    [Route(ApiRoutes.Identity.Refresh)]
    public async Task<IActionResult> Refresh([FromBody] GetByToken refreshRequest, CancellationToken token)
    {
        if (!ModelState.IsValid)
        {
            return BadRequestModelState();
        }

        bool isValidRefreshToken = _refreshTokenValidator.Validate(refreshRequest.Token);
        if (!isValidRefreshToken)
        {
            return BadRequest(new ErrorResponses("Invalid refresh token."));
        }
        var query = new GetByToken() { Token = refreshRequest.Token };

        var result = await _mediator.Send(query, token);
        //////GetByToken
        var refreshTokenDTO = result.Payload;

        if (refreshTokenDTO == null)
        {
            return NotFound(new ErrorResponses("Invalid refresh token."));
        }
        var cmd = new DeleteRefreshToken()
        {
            Id = refreshTokenDTO.Id
        };
        var command = _mapper.Map<DeleteRefreshToken>(cmd);
        var result2 = await _mediator.Send(command, token);
        if (result2.IsError) return HandleErrorResponse(result.Errors);

        var query2 = new GetUserProfileByIdentityId() { IdentityId = refreshTokenDTO.IdentityId };
        var result3 = await _mediator.Send(query2, token);

        if (result3.IsError) return HandleErrorResponse(result3.Errors);

        var userDetails = result3.Payload;

        var identityUser = new IdentityUser()
        {
            Id = refreshTokenDTO.IdentityId,
            Email = userDetails.EmailAddress
        };
        if (identityUser == null)
        {
            return NotFound(new ErrorResponses("User not found."));
        }

        AuthenticatedUserResponse response = await _authenticator.Authenticate(identityUser, userDetails.UserProfileId.ToString());

        return Ok(response);
    }


    [HttpDelete]
    [Route(ApiRoutes.Identity.SignOut)]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public async Task<IActionResult> SignOut(CancellationToken token)
    {
        var userIdentityId = HttpContext.GetIdentityIdClaimValue();
        bool isLogin = userIdentityId == null;
        if (isLogin)
        {
            return Unauthorized();
        }
        var cmd = new DeleteAllRefreshToken()
        {
            IndentityId = userIdentityId.ToString()
        };
        var command = _mapper.Map<DeleteAllRefreshToken>(cmd);
        var result = await _mediator.Send(command, token);
        if (result.IsError) return Unauthorized();
        return Ok();
    }

    private IActionResult BadRequestModelState()
    {
        IEnumerable<string> errorMessages = ModelState.Values.SelectMany(v => v.Errors.Select(e => e.ErrorMessage));

        return BadRequest(new ErrorResponses(errorMessages));
    }
}