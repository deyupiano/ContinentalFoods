
using ContinentalFoods.Application.Models;
using ContinentalFoods.Domain.Aggregates.PostAggregate;
using MediatR;

namespace ContinentalFoods.Application.Posts.Commands;

public class UpdatePostComment : IRequest<OperationResult<PostComment>>
{
    public Guid UserProfileId { get; set; }
    public Guid PostId { get; set; }
    public Guid CommentId { get; set; }
    public string UpdatedText { get; set; }
}