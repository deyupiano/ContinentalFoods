
using ContinentalFoods.Application.Services.Authenticators;
using ContinentalFoods.Application.Services.TokenValidators;

namespace ContinentalFoods.WebApi.Registrars
{
    public class UtilitiesRegistrar : IWebApplicationBuilderRegistrar
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddAutoMapper(typeof(Program), typeof(GetAllUserProfiles));
            builder.Services.AddMediatR(typeof(GetAllUserProfiles));
            builder.Services.AddCors();
        }
    }
}
