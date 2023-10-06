
using ContinentalFoods.Application.Models;
using ContinentalFoods.Domain.Aggregates.PostAggregate;
using MediatR;

namespace ContinentalFoods.Application.Posts.Commands;

public class AddInteraction : IRequest<OperationResult<PostInteraction>>
{
    public Guid PostId { get; set; }
    public Guid UserProfileId { get; set; }
    public InteractionType Type { get; set; }
}