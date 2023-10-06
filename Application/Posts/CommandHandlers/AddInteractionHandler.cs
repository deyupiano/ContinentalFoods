using ContinentalFoods.Application.Enums;
using ContinentalFoods.Application.Models;
using ContinentalFoods.Application.Posts.Commands;
using ContinentalFoods.Domain.Aggregates.PostAggregate;
using DataAccessLayer;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ContinentalFoods.Application.Posts.CommandHandlers;

public class AddInteractionHandler : IRequestHandler<AddInteraction, OperationResult<PostInteraction>>
{
    private readonly DataContext _ctx;

    public AddInteractionHandler(DataContext ctx)
    {
        _ctx = ctx;
    }
    
    public async Task<OperationResult<PostInteraction>> Handle(AddInteraction request, 
        CancellationToken cancellationToken)
    {
        var result = new OperationResult<PostInteraction>();
        try
        {
            var post = await _ctx.Posts.Include(p => p.Interactions)
                .FirstOrDefaultAsync(p => p.PostId == request.PostId, cancellationToken);

            if (post == null)
            {
                result.AddError(ErrorCode.NotFound, PostsErrorMessages.PostNotFound);
                return result;
            }
            
            var interaction = PostInteraction.CreatePostInteraction(request.PostId, request.UserProfileId,
                request.Type);

            post.AddInteraction(interaction);

            _ctx.Posts.Update(post);
            await _ctx.SaveChangesAsync(cancellationToken);

            result.Payload = interaction;

        }
        catch (Exception e)
        {
            result.AddUnknownError(e.Message);
        }

        return result;
    }
}