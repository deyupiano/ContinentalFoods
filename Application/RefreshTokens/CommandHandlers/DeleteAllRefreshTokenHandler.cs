

using ContinentalFoods.Application.Enums;
using ContinentalFoods.Application.Models;
using ContinentalFoods.Application.RefreshTokens.Commands;
using ContinentalFoods.Domain.Aggregates.RefreshTokenAggregate;
using ContinentalFoods.Domain.Exceptions;
using DataAccessLayer;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ContinentalFoods.Application.RefreshTokens.CommandHandlers;

public class DeleteAllRefreshTokenHandler : IRequestHandler<DeleteAllRefreshToken, OperationResult<RefreshToken>>
{
    private readonly DataContext _ctx;

    public DeleteAllRefreshTokenHandler(DataContext ctx)
    {
        _ctx = ctx;
    }
    
    public async Task<OperationResult<RefreshToken>> Handle(DeleteAllRefreshToken request, CancellationToken cancellationToken)
    {
        var result = new OperationResult<RefreshToken>();
        try
        {
            IEnumerable<RefreshToken> refreshTokens = await _ctx.RefreshTokens
                .Where(t => t.IdentityId == request.IndentityId)
                .ToListAsync();
            if (refreshTokens is null)
            {
                result.AddError(ErrorCode.NotFound,
                    string.Format(RefreshTokenErrorMessages.RefreshTokenNotFound, request.IndentityId));

                return result;
            }
            _ctx.RefreshTokens.RemoveRange(refreshTokens);
            await _ctx.SaveChangesAsync(cancellationToken);

            result.Payload = null;
        }
        catch (RefreshTokenNotValidException e)
        {
            e.ValidationErrors.ForEach(er => result.AddError(ErrorCode.ValidationError, er));
        }

        catch (Exception e)
        {
            result.AddUnknownError(e.Message);
        }
        
        return result;
    }
}