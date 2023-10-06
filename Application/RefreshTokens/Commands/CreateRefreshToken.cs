
using ContinentalFoods.Application.Models;
using ContinentalFoods.Domain.Aggregates.RefreshTokenAggregate;
using MediatR;

namespace ContinentalFoods.Application.RefreshTokens.Commands;

public class CreateRefreshToken : IRequest<OperationResult<RefreshToken>>
{
    public Guid Id { get; set; }
    public string IdentityId { get; set; }
    public string Token { get; set; }
}