﻿using ContinentalFoods.Application.Identity.Dtos;

namespace ContinentalFoods.Api.MappingProfiles;

public class IdentitMappings : Profile
{
    public IdentitMappings()
    {
        CreateMap<UserRegistration, RegisterIdentity>();
        CreateMap<Login, LoginCommand>();
        CreateMap<IdentityUserProfileDto, IdentityUserProfile>();
    }
}