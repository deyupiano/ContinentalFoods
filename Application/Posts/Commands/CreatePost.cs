
using ContinentalFoods.Application.Models;
using ContinentalFoods.Domain.Aggregates.PostAggregate;
using MediatR;

namespace ContinentalFoods.Application.Posts.Commands;

public class CreatePost : IRequest<OperationResult<Post>>
{
    public Guid UserProfileId { get; set; }
    public string TextContent { get; set; }
}