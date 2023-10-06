
using ContinentalFoods.Application.Models;
using ContinentalFoods.Domain.Aggregates.PostAggregate;
using MediatR;

namespace ContinentalFoods.Application.Posts.Queries;

public class GetPostInteractions : IRequest<OperationResult<List<PostInteraction>>>
{
    public Guid PostId { get; set; }
}