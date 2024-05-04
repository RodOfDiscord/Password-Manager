using Presentation.Views;

namespace Presentation.Presenters
{
    public abstract class BasePresenter<TView> : IPresenter where TView : IView
    {
        public TView View { get; protected set; }

        public BasePresenter(TView view) 
        {
            View = view;
        }

        public virtual void Run()
        {
            View.Show();
        }
    }
}
