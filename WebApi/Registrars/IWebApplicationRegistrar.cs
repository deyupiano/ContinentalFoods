namespace ContinentalFoods.WebApi.Registrars
{
    public interface IWebApplicationRegistrar: IRegistrar
    {
        public void RegisterPipelineComponents(WebApplication app);
    }
}
