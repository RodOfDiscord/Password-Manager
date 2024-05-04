using Presentation.Views;

namespace Presentation.Presenters
{
    public class LoginPresenter : BasePresenter<ILoginView>
    {
        public LoginPresenter(ILoginView view) : base(view)
        {
        }
    }
}
