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
        static Profile profile;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            ServiceProvider = CreateHostBuilder().Build().Services;
            CreateKey();
            LoginPresenter loginPresenter = ServiceProvider.GetRequiredService<LoginPresenter>();
            loginPresenter.LoggedIn += SetLoggedInProfile;
            loginPresenter.Run();
            if (loginPresenter.View.GetDialogResult() == DialogResult.OK)
                RunMainForm();
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
                    services.AddTransient<INoteService, NoteService>();
                    services.AddTransient<ICategoryService,CategoryService>();
                    services.AddTransient<IBaseRepository<Profile>, ProfileRepository>();
                    services.AddTransient<LoginPresenter>();
                    services.AddTransient<EditNotePresenter>();
                    services.AddTransient<ILoginView, LoginForm>();
                    services.AddTransient<IMainView, MainForm>();
                    services.AddTransient<IEditNoteView, EditNoteForm>();
                    services.AddTransient<ILoginService, LoginService>();
                    services.AddTransient<IProfileRepository, ProfileRepository>();
                    services.AddTransient<BaseRepository<Category>>();
                    services.AddTransient<INoteRepository, NoteRepository>();
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

        private static void SetLoggedInProfile(object? sender, string username)
        {
            Profile? profile = ServiceProvider.GetRequiredService<IProfileService>().FindByNameWithAll(username);
            if (profile == null)
            {
                MessageBox.Show("Unable display window", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Program.profile = profile;
        }

        private static void RunMainForm()
        {
            IMainView view = ServiceProvider.GetRequiredService<IMainView>();
            EditNotePresenter editNotePresenter = ServiceProvider.GetRequiredService<EditNotePresenter>();
            MainPresenter mainPresenter = new MainPresenter(view, editNotePresenter, profile);
            mainPresenter.Run();
        }
    }
}