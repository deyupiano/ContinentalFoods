

using ContinentalFoods.Application.Enums;
using ContinentalFoods.Application.Models;
using ContinentalFoods.Application.Posts.Queries;
using ContinentalFoods.Domain.Aggregates.PostAggregate;
using DataAccessLayer;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ContinentalFoods.Application.Posts.QueryHandlers;

public class GetPostInteractionsHandler : IRequestHandler<GetPostInteractions, OperationResult<List<PostInteraction>>>
{
    private readonly DataContext _ctx;

    public GetPostInteractionsHandler(DataContext ctx)
    {
        _ctx = ctx;
    }
    
    public async Task<OperationResult<List<PostInteraction>>> Handle(GetPostInteractions request, 
        CancellationToken cancellationToken)
    {
        var result = new OperationResult<List<PostInteraction>>();

        try
        {
            var post = await _ctx.Posts
                .Include(p => p.Interactions)
                .ThenInclude(i => i.UserProfile)
                .FirstOrDefaultAsync(p => p.PostId == request.PostId, cancellationToken);

            if (post == null)
            {
                result.AddError(ErrorCode.NotFound, PostsErrorMessages.PostNotFound);
                return result;
            }
            
            result.Payload = post.Interactions.ToList();

        }
        catch (Exception e)
        {
            result.AddUnknownError(e.Message);
        }

        return result;
    }
}