
using ContinentalFoods.Application.Models;
using ContinentalFoods.Domain.Aggregates.PostAggregate;
using MediatR;

namespace ContinentalFoods.Application.Posts.Queries;

public class GetPostComments : IRequest<OperationResult<List<PostComment>>>
{
    public Guid PostId { get; set; }
}