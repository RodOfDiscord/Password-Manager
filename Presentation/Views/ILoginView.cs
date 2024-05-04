using Domain;

namespace Presentation.Views
{
    public interface ILoginView : IView
    {
        void SetUserName(string username);
        event EventHandler<(string, string)> TryLogin;
        public void DisplayErrorMessage(string message);
    }
}
