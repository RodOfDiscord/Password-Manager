using Domain;

namespace Presentation.Views
{
    public interface IAddProfileView : IView
    {
        event EventHandler<Profile> AddProfile;
    }
}
