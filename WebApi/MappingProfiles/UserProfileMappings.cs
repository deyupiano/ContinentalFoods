﻿using ContinentalFoods.Domain.Aggregates.UserProfileAggregate;

namespace ContinentalFoods.WebApi.MappingProfiles
{
    public class UserProfileMappings : Profile
    {
        public UserProfileMappings()
        {
            CreateMap<UserProfileCreateUpdate, UpdateUserProfileBasicInfo>();
            CreateMap<UserProfile, UserProfileResponse>();
            CreateMap<BasicInfo, BasicInformation>();
            CreateMap<UserProfile, InteractionUser>()
                .ForMember(dest => dest.FullName, opt 
                => opt.MapFrom(src 
                => src.BasicInfo.FirstName + " " + src.BasicInfo.LastName))
                .ForMember(dest => dest.City, opt 
                => opt.MapFrom(src => src.BasicInfo.CurrentCity));
        }
    }
}
