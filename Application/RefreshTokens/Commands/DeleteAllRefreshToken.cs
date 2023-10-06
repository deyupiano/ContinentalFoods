
using ContinentalFoods.Application.Models;
using ContinentalFoods.Domain.Aggregates.RefreshTokenAggregate;
using MediatR;

namespace ContinentalFoods.Application.RefreshTokens.Commands;

public class DeleteAllRefreshToken : IRequest<OperationResult<RefreshToken>>
{
    public string IndentityId { get; set; }
}