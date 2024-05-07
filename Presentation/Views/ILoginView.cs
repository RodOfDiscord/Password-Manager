using Domain;

namespace Presentation.Views
{
    public interface ILoginView : IView
    {
        void DisplayProfiles(IEnumerable<Profile> profiles);
        void ClearProfiles();
        event EventHandler<(string, string)> TryLogin;
        public void DisplayErrorMessage(string message);
        void SetDialogResult(DialogResult dialogResult);
        DialogResult GetDialogResult();
        event EventHandler OpenAddProfileView;
    }
}