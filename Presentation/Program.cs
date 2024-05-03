using Domain.Cipher;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Presentation
{
    internal static class Program
    {
        public static IServiceProvider? ServiceProvider { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            ServiceProvider = CreateHostBuilder().Build().Services;
            CreateKey();
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
                        options.UseSqlite(context.Configuration.GetConnectionString("Default"));
                    });
                    services.AddScoped((provider) =>
                    {
                        return new KeyManager("Key.dat");
                    });
                });
        }

        static void CreateKey()
        {
            KeyManager keyManager = ServiceProvider.GetRequiredService<KeyManager>();
            if (!keyManager.KeyExists())
                keyManager.EncryptToFile(EncryptionKeyGenerator.Generate());
        }
    }
}