using ContinentalFoods.Application.Identity.Dtos;
using ContinentalFoods.Application.Models;
using MediatR;
using System.Security.Claims;

namespace ContinentalFoods.Application.Identity.Queries;

public class GetCurrentUser : IRequest<OperationResult<IdentityUserProfileDto>>
{
    public Guid UserProfileId { get; set; }
    public ClaimsPrincipal ClaimsPrincipal { get; set; }
}