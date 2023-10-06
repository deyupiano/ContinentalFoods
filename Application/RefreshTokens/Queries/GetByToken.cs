using ContinentalFoods.Application.Models;
using ContinentalFoods.Domain.Aggregates.RefreshTokenAggregate;
using MediatR;

namespace ContinentalFoods.Application.RefreshTokens.Queries;

public class GetByToken : IRequest<OperationResult<RefreshToken>>
{
    public string Token { get; set; }
}