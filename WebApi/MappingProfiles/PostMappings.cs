using PostInteraction = ContinentalFoods.Domain.Aggregates.PostAggregate.PostInteraction;

namespace ContinentalFoods.WebApi.MappingProfiles;

public class PostMappings : Profile
{
    public PostMappings()
    {
        CreateMap<Post, PostResponse>();
        CreateMap<PostComment, PostCommentResponse>();
        CreateMap<PostInteraction, ContinentalFoods.WebApi.Contracts.Posts.Responses.PostInteraction>()
            .ForMember(dest 
                => dest.Type, opt 
                => opt.MapFrom(src 
                => src.InteractionType.ToString()))
            .ForMember(dest => dest.Author, opt 
            => opt.MapFrom(src => src.UserProfile));
    }
}