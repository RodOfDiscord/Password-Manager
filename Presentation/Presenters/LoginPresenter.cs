using Presentation.Views;
using Services;

namespace Presentation.Presenters
{
    public class LoginPresenter : BasePresenter<ILoginView>
    {
        ILoginService loginService;
        public event EventHandler<string> LoginSuccess;

        public LoginPresenter(ILoginView view, ILoginService loginService) : base(view)
        {
            this.loginService = loginService;
            view.TryLogin += tryLogin;
        }

        private void tryLogin(object? sender, (string, string) profileData)
        {
            bool isSuccess = loginService.Login(profileData.Item1, profileData.Item2);
            if (isSuccess)
            {
                LoginSuccess.Invoke(this, profileData.Item1);
            }
            else
            {
                View.DisplayErrorMessage("Login failed");
            }
        }
    }
}
