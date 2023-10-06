using AutoMapper;
using ContinentalFoods.Application.Identity.Dtos;
using ContinentalFoods.Domain.Aggregates.UserProfileAggregate;

namespace ContinentalFoods.Application.Identity.MappingProfiles;

public class IdentityProfileWithId : Profile
{
    public IdentityProfileWithId()
    {
        CreateMap<UserProfile, IdentityUserProfileWithIdDto>()
            .ForMember(dest => dest.UserProfileId, opt
            => opt.MapFrom(src => src.UserProfileId))
            .ForMember(dest => dest.Phone, opt 
            => opt.MapFrom(src => src.BasicInfo.Phone))
            .ForMember(dest => dest.CurrentCity, opt 
            => opt.MapFrom(src => src.BasicInfo.CurrentCity))
            .ForMember(dest => dest.EmailAddress, opt 
            => opt.MapFrom(src => src.BasicInfo.EmailAddress))
            .ForMember(dest => dest.FirstName, opt 
            => opt.MapFrom(src => src.BasicInfo.FirstName))
            .ForMember(dest => dest.LastName, opt 
            => opt.MapFrom(src => src.BasicInfo.LastName))
            .ForMember(dest => dest.DateOfBirth, opt 
            => opt.MapFrom(src => src.BasicInfo.DateOfBirth));
    }
}