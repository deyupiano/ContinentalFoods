
using ContinentalFoods.Application.Models;
using ContinentalFoods.Domain.Aggregates.PostAggregate;
using MediatR;

namespace ContinentalFoods.Application.Posts.Commands;

public class DeletePost : IRequest<OperationResult<Post>>
{
    public Guid PostId { get; set; }
    public Guid UserProfileId { get; set; }
}