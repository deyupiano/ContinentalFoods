using ContinentalFoods.Application.Services.Authenticators;
using ContinentalFoods.Application.Services.TokenValidators;

namespace ContinentalFoods.WebApi.Registrars;

public class ApplicationLayerRegistrar : IWebApplicationBuilderRegistrar
{
    public void RegisterServices(WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IdentityService>();
        builder.Services.AddSingleton<RefreshTokenValidator>();
        builder.Services.AddScoped<Authenticator>();
        builder.Services.AddScoped<TokenGeneratorService>();
    }
}