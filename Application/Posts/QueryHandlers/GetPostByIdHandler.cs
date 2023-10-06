using ContinentalFoods.Application.Enums;
using ContinentalFoods.Application.Models;
using ContinentalFoods.Application.Posts.Queries;
using ContinentalFoods.Domain.Aggregates.PostAggregate;
using DataAccessLayer;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ContinentalFoods.Application.Posts.QueryHandlers;

public class GetByTokenHandler : IRequestHandler<GetPostById, OperationResult<Post>>
{
    private readonly DataContext _ctx;
    public GetByTokenHandler(DataContext ctx)
    {
        _ctx = ctx;
    }
    public async Task<OperationResult<Post>> Handle(GetPostById request, CancellationToken cancellationToken)
    {
        var result = new OperationResult<Post>();
        var post = await _ctx.Posts
            .FirstOrDefaultAsync(p => p.PostId == request.PostId);
            
        if (post is null)
        {
            result.AddError(ErrorCode.NotFound, 
                string.Format(PostsErrorMessages.PostNotFound, request.PostId));
            return result;
        }

        result.Payload = post;
        return result;
    }
}