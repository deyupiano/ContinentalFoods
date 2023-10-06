using ContinentalFoods.Application.Models;
using ContinentalFoods.Domain.Aggregates.PostAggregate;
using MediatR;

namespace ContinentalFoods.Application.Posts.Commands;

public class UpdatePostText : IRequest<OperationResult<Post>>
{
    public string NewText { get; set; }
    public Guid PostId { get; set; }
    public Guid UserProfileId { get; set; }
}