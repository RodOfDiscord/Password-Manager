using Domain;
using Presentation.Views;
using Services;

namespace Presentation.Presenters
{
    public class LoginPresenter : BasePresenter<ILoginView>
    {
        ILoginService loginService;
        private readonly AddProfilePresenter addProfilePresenter;
        private readonly IProfileService profileService;
        public event EventHandler<string>? LoggedIn;

        public LoginPresenter(ILoginView view, ILoginService loginService, AddProfilePresenter addProfilePresenter, IProfileService profileService) : base(view)
        {
            this.loginService = loginService;
            this.addProfilePresenter = addProfilePresenter;
            this.profileService = profileService;
            view.TryLogin += TryLogin;
            view.OpenAddProfileView += AddProfile;
            view.DisplayProfiles(profileService.GetProfiles());
            addProfilePresenter.ProfileAdded += ProfileAdded;
        }

        private void ProfileAdded(object? sender, EventArgs e)
        {
            View.ClearProfiles();
            View.DisplayProfiles(profileService.GetProfiles());
        }

        private void AddProfile(object? sender, EventArgs e)
        {
            addProfilePresenter.Run();
        }

        private void TryLogin(object? sender, (string, string) profileData)
        {
            bool isSuccess = loginService.Login(profileData.Item1, profileData.Item2);
            if (isSuccess)
            {
                View.SetDialogResult(DialogResult.OK);
                LoggedIn?.Invoke(this, profileData.Item1);
            }
            else
            {
                View.DisplayErrorMessage("Login failed");
            }
        }
    }
}