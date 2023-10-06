
using AutoMapper;
using ContinentalFoods.Application.Identity.Dtos;
using ContinentalFoods.Application.Identity.Queries;
using ContinentalFoods.Application.Models;
using DataAccessLayer;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ContinentalFoods.Application.Identity.QueryHandlers;

public class GetUserProfileByIdentityIdHandler
    : IRequestHandler<GetUserProfileByIdentityId, OperationResult<IdentityUserProfileWithIdDto>>
{
    private readonly DataContext _ctx;
    private readonly UserManager<IdentityUser> _userManager;
    private readonly IMapper _mapper;
    private OperationResult<IdentityUserProfileWithIdDto> _result = new();

    public GetUserProfileByIdentityIdHandler(DataContext ctx, UserManager<IdentityUser> userManager, IMapper mapper)
    {
        _ctx = ctx;
        _userManager = userManager;
        _mapper = mapper;
    }

    public async Task<OperationResult<IdentityUserProfileWithIdDto>> Handle(GetUserProfileByIdentityId request, 
        CancellationToken cancellationToken)
    {

        var profile = await _ctx.UserProfiles
            .FirstOrDefaultAsync(up => up.IdentityId == request.IdentityId, cancellationToken);

        _result.Payload = _mapper.Map<IdentityUserProfileWithIdDto>(profile);
        _result.Payload.UserName = profile.BasicInfo.EmailAddress;
        return _result;
    }
}