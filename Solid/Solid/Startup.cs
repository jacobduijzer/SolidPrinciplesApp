using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Solid.Helpers;
using Solid.Services;
using Solid.SolidPrinciples;
using Xamarin.Essentials;

namespace Solid
{
    public static class Startup
    {
        private const string APP_SETTINGS_FILE = "Solid.appsettings.json";

        public static App Init(Action<HostBuilderContext, IServiceCollection> nativeConfigureServices)
        {
            var systemDir = FileSystem.CacheDirectory;
            Utils.ExtractSaveResource(APP_SETTINGS_FILE, systemDir);
            var fullConfig = Path.Combine(systemDir, APP_SETTINGS_FILE);

            var host = new HostBuilder()
                            .ConfigureHostConfiguration(c =>
                            {
                                c.AddCommandLine(new string[] { $"ContentRoot={FileSystem.AppDataDirectory}" });
                                c.AddJsonFile(fullConfig);
                            })
                            .ConfigureServices((c, x) =>
                            {
                                nativeConfigureServices(c, x);
                                ConfigureServices(c, x);
                            })
                            .ConfigureLogging(config => config.AddConsole(options => options.DisableColors = true))
                            .Build();

            App.ServiceProvider = host.Services;

            return App.ServiceProvider.GetService<App>();
        }


        private static void ConfigureServices(HostBuilderContext ctx, IServiceCollection services)
        {
            //services.AddSingleton<AppShell>(factory => new AppShell());
            services.AddTransient<IPrincipleService, OfflinePrincipleService>();
            services.AddTransient<PrinciplesViewModel>();
            services.AddTransient<PrinciplesView>();
            services.AddSingleton<App>();
        }
    }
}
