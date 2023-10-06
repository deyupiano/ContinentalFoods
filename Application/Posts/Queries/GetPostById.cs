using ContinentalFoods.Application.Models;
using ContinentalFoods.Domain.Aggregates.PostAggregate;
using MediatR;

namespace ContinentalFoods.Application.Posts.Queries;

public class GetPostById : IRequest<OperationResult<Post>>
{
    public Guid PostId { get; set; }
}