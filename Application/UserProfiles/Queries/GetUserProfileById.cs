
using ContinentalFoods.Application.Models;
using ContinentalFoods.Application.UserProfiles.Models;
using MediatR;

namespace ContinentalFoods.Application.UserProfiles.Queries
{
    public class GetUserProfileById : IRequest<OperationResult<UserProfileDto>>
    {
        public Guid UserProfileId { get; set; }
    }
}
