using ContinentalFoods.Application.Enums;
using ContinentalFoods.Application.Models;
using ContinentalFoods.Application.Posts.Queries;
using ContinentalFoods.Application.RefreshTokens.Queries;
using ContinentalFoods.Domain.Aggregates.PostAggregate;
using ContinentalFoods.Domain.Aggregates.RefreshTokenAggregate;
using DataAccessLayer;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ContinentalFoods.Application.RefreshTokens.QueryHandlers;

public class GetByTokenHandler : IRequestHandler<GetByToken, OperationResult<RefreshToken>>
{
    private readonly DataContext _ctx;
    public GetByTokenHandler(DataContext ctx)
    {
        _ctx = ctx;
    }
    public async Task<OperationResult<RefreshToken>> Handle(GetByToken request, CancellationToken cancellationToken)
    {
        var result = new OperationResult<RefreshToken>();
        var refreshToken = await _ctx.RefreshTokens
            .FirstOrDefaultAsync(p => p.Token == request.Token);
            
        if (refreshToken is null)
        {
            result.AddError(ErrorCode.NotFound, 
                string.Format(RefreshTokenErrorMessages.RefreshTokenNotFound, request.Token));
            return result;
        }

        result.Payload = refreshToken;
        return result;
    }
}