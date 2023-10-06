
using ContinentalFoods.Application.Models;
using ContinentalFoods.Domain.Aggregates.UserProfileAggregate;
using MediatR;

namespace ContinentalFoods.Application.UserProfiles.Queries
{
    public class GetAllUserProfiles : IRequest<OperationResult<IEnumerable<UserProfile>>>
    {
    }
}
