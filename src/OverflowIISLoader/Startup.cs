using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Framework.Configuration;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Framework.Logging;

namespace OverflowIISLoader
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }
        
        public void ConfigureServices(IServiceCollection services)
        {
            //Only occurs if AccountManager is registered as Singleton
            services.AddSingleton(typeof(OverflowManager));
            //This one works:
            //services.AddScoped(typeof(OverflowManager));

            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.MinimumLevel = LogLevel.Information;
            loggerFactory.AddConsole();
            app.UseErrorPage();
            app.UseStaticFiles();
            app.UseMvc();
        }
    }
}