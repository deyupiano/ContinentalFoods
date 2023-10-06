

using ContinentalFoods.Application.Enums;
using ContinentalFoods.Application.Models;
using ContinentalFoods.Application.RefreshTokens.Commands;
using ContinentalFoods.Domain.Aggregates.RefreshTokenAggregate;
using ContinentalFoods.Domain.Exceptions;
using DataAccessLayer;
using MediatR;

namespace ContinentalFoods.Application.RefreshTokens.CommandHandlers;

public class CreateRefreshTokenHandler : IRequestHandler<CreateRefreshToken, OperationResult<RefreshToken>>
{
    private readonly DataContext _ctx;
    private readonly List<RefreshToken> _refreshTokens = new List<RefreshToken>();
    public CreateRefreshTokenHandler(DataContext ctx)
    {
        _ctx = ctx;
    }
    
    public async Task<OperationResult<RefreshToken>> Handle(CreateRefreshToken request, CancellationToken cancellationToken)
    {
        var result = new OperationResult<RefreshToken>();
        try
        {
            var rt = RefreshToken.CreateRefreshToken(Guid.NewGuid(), request.IdentityId, request.Token);
 
            _refreshTokens.Add(rt);
            _ctx.RefreshTokens.Add(rt);
            await _ctx.SaveChangesAsync(cancellationToken);

            result.Payload = rt;
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