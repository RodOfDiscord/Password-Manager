using Presentation.Views;
using Services;

namespace Presentation.Presenters
{
    public class LoginPresenter : BasePresenter<ILoginView>
    {
        ILoginService loginService;
        public event EventHandler<string>? LoggedIn;
        public LoginPresenter(ILoginView view, ILoginService loginService, IProfileService profileService) : base(view)
        {
            this.loginService = loginService;
            view.TryLogin += TryLogin;
            view.DisplayProfiles(profileService.GetProfiles());
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

        public override void Run()
        {
            LoginForm form = View as LoginForm;
            form.ShowDialog();
        }
    }
}