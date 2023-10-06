namespace ContinentalFoods.WebApi.Registrars
{
    public class MvcWebAppRegistrar : IWebApplicationRegistrar
    {
        public void RegisterPipelineComponents(WebApplication app)
        {
            app.UseCors(option => option.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                var provider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();
                foreach (var description in provider.ApiVersionDescriptions)
                {
                    options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json",
                        description.ApiVersion.ToString());
                }
            });
            app.UseAuthorization();
            app.MapControllers();
            app.UseHttpsRedirection();


            //app.UseSerilogRequestLogging();

        }
    }
}
