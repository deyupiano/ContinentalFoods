
using ContinentalFoods.Application.Models;
using ContinentalFoods.Domain.Aggregates.PostAggregate;
using ContinentalFoods.Domain.Aggregates.RefreshTokenAggregate;
using MediatR;

namespace ContinentalFoods.Application.RefreshTokens.Commands;

public class DeleteRefreshToken : IRequest<OperationResult<RefreshToken>>
{
    public Guid Id { get; set; }
}