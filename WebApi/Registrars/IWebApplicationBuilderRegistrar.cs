namespace ContinentalFoods.WebApi.Registrars
{
    public interface IWebApplicationBuilderRegistrar: IRegistrar
    {
        void RegisterServices(WebApplicationBuilder builder);
    }
}
