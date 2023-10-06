using MediatR;

namespace ContinentalFoods.WebApi.Extensions;

public static class HttpContextExtensions
{
    public static Guid GetUserProfileIdClaimValue(this HttpContext context)
    {
        return GetGuidClaimValue("UserProfileId", context);
    }

    public static Guid GetIdentityIdClaimValue(this HttpContext context)
    {
        return GetGuidClaimValue("IdentityId", context);
    }

    private static Guid GetGuidClaimValue(string key, HttpContext context)
    {
        var identity = context.User.Identity as ClaimsIdentity;
        return Guid.Parse(identity?.FindFirst(key)?.Value);
    }
    private static IdentityUser GetIdentityUser(HttpContext context)
    {
        var identity = new IdentityUser
        {
            Id = GetGuidClaimValue("IdentityId", context).ToString()
        };
        return identity;
    }
}