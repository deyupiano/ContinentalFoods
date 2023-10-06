using ContinentalFoods.Application.Identity.Dtos;
using ContinentalFoods.Application.Models;
using MediatR;
using System.Security.Claims;

namespace ContinentalFoods.Application.Identity.Queries;

public class GetUserProfileByIdentityId : IRequest<OperationResult<IdentityUserProfileWithIdDto>>
{
    public string IdentityId { get; set; }
}