
using ContinentalFoods.Application.Identity.Dtos;
using ContinentalFoods.Application.Models;
using MediatR;

namespace ContinentalFoods.Application.Identity.Commands;

public class LoginCommand : IRequest<OperationResult<IdentityUserProfileDto>>
{
    public string Username { get; set; }
    public string Password { get; set; }
}