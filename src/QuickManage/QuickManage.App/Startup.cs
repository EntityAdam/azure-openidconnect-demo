using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using QuickManage.App.Services;

namespace QuickManage.App
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Example of a data service
            services.AddSingleton<WeatherForecastService>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
