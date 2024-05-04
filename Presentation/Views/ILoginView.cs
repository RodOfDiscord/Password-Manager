using Domain;

namespace Presentation.Views
{
    public interface ILoginView : IView
    {
        public void SetProfile(Profile profile);
    }
}
