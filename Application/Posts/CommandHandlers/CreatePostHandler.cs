﻿

using ContinentalFoods.Application.Enums;
using ContinentalFoods.Application.Models;
using ContinentalFoods.Application.Posts.Commands;
using ContinentalFoods.Domain.Aggregates.PostAggregate;
using ContinentalFoods.Domain.Exceptions;
using DataAccessLayer;
using MediatR;

namespace ContinentalFoods.Application.Posts.CommandHandlers;

public class CreatePostHandler : IRequestHandler<CreatePost, OperationResult<Post>>
{
    private readonly DataContext _ctx;

    public CreatePostHandler(DataContext ctx)
    {
        _ctx = ctx;
    }
    
    public async Task<OperationResult<Post>> Handle(CreatePost request, CancellationToken cancellationToken)
    {
        var result = new OperationResult<Post>();
        try
        {
            var post = Post.CreatePost(request.UserProfileId, request.TextContent);
            _ctx.Posts.Add(post);
            await _ctx.SaveChangesAsync(cancellationToken);

            result.Payload = post;
        }
        catch (PostNotValidException e)
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