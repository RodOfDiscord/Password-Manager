using Domain;

namespace Presentation.Views
{
    public interface ILoginView : IView
    {
        void DisplayProfiles(IEnumerable<Profile> profiles);
        event EventHandler<(string, string)> TryLogin;
        public void DisplayErrorMessage(string message);
    }
}
