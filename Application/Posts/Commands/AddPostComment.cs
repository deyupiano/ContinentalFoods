
using ContinentalFoods.Application.Models;
using ContinentalFoods.Domain.Aggregates.PostAggregate;
using MediatR;

namespace ContinentalFoods.Application.Posts.Commands;

public class AddPostComment : IRequest<OperationResult<PostComment>>
{
    public Guid PostId { get; set; }
    public Guid UserProfileId { get; set; }
    public string CommentText { get; set; }
}