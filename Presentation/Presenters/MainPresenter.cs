using Domain;
using Presentation.Views;

namespace Presentation.Presenters
{
    public class MainPresenter : BasePresenter<IMainView>
    {
        public MainPresenter(IMainView view, Profile profile) : base(view)
        {
            view.SetAttributes(profile.Name);
        }
    }
}
