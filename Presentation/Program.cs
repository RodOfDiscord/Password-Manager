using Domain;
using Domain.Cipher;
using Infrastructure;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Presentation.Presenters;
using Presentation.Views;
using Services;

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
            ServiceProvider.GetRequiredService<BasePresenter<ILoginView>>().Run();
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
                    services.AddTransient<IProfileService, ProfileService>();
                    services.AddTransient<IBaseRepository<Profile>, ProfileRepository>();
                    services.AddTransient<BasePresenter<ILoginView>, LoginPresenter>();
                    services.AddTransient<ILoginService, LoginService>();
                    services.AddTransient<IProfileRepository, ProfileRepository>();
                    services.AddTransient<IEncryptionService, EncryptionService>(provider =>
                    {
                        return new EncryptionService(provider.GetRequiredService<KeyManager>().GetDecryptedKey());
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