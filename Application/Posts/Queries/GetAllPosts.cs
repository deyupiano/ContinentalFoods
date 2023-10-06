
using ContinentalFoods.Application.Models;
using ContinentalFoods.Domain.Aggregates.PostAggregate;
using MediatR;

namespace ContinentalFoods.Application.Posts.Queries;

public class GetAllPosts : IRequest<OperationResult<List<Post>>>
{
    
}