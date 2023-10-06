

using ContinentalFoods.Application.Enums;
using ContinentalFoods.Application.Models;
using ContinentalFoods.Application.Posts;
using ContinentalFoods.Application.Posts.Commands;
using ContinentalFoods.Application.RefreshTokens.Commands;
using ContinentalFoods.Domain.Aggregates.PostAggregate;
using ContinentalFoods.Domain.Aggregates.RefreshTokenAggregate;
using ContinentalFoods.Domain.Exceptions;
using DataAccessLayer;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ContinentalFoods.Application.RefreshTokens.CommandHandlers;

public class DeleteRefreshTokenHandler : IRequestHandler<DeleteRefreshToken, OperationResult<RefreshToken>>
{
    private readonly DataContext _ctx;

    public DeleteRefreshTokenHandler(DataContext ctx)
    {
        _ctx = ctx;
    }
    
    public async Task<OperationResult<RefreshToken>> Handle(DeleteRefreshToken request, CancellationToken cancellationToken)
    {
        var result = new OperationResult<RefreshToken>();
        try
        {
            var rt = await _ctx.RefreshTokens.FirstOrDefaultAsync(p => p.Id == request.Id, cancellationToken: cancellationToken);

            if (rt is null)
            {
                result.AddError(ErrorCode.NotFound,
                    string.Format(RefreshTokenErrorMessages.RefreshTokenNotFound, request.Id));;
                return result;
            }
            _ctx.RefreshTokens.Remove(rt);
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