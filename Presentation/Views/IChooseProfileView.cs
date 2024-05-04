using Domain;

namespace Presentation.Views
{
    public interface IChooseProfileView : IView
    {
        void DisplayProfiles(IEnumerable<Profile> profiles);
        event EventHandler<string> ProfileSelected;
        void DisplayLoginUC(UserControl userControl);
    }
}
