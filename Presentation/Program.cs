using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Configuration;

namespace Presentation
{
    internal static class Program
    {
        public static IServiceProvider? ServiceProvider { get; private set; }
        public static IConfigurationRoot? Configuration { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Configuration = CreateConfigurationBuilder().Build();
            ServiceProvider = CreateHostBuilder().Build().Services;
            Application.Run(ServiceProvider.GetRequiredService<MainForm>());
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddTransient<MainForm>();
                    services.AddDbContext<PasswordStorageContext>(options =>
                    {
                        options.UseSqlite(Configuration?.GetConnectionString("Default"));
                    });
                });
        }

        static IConfigurationBuilder CreateConfigurationBuilder()
        {
            return new ConfigurationBuilder().AddJsonFile
                (
                    Path.Combine(Directory.GetCurrentDirectory(),
                    "appsettings.json")
                );
        }
    }
}