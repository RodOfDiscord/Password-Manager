using Domain;
using Presentation.Presenters;

namespace Presentation
{
    public interface IMainPresenterFactory
    {
        MainPresenter Create(Profile profile);
    }
}
