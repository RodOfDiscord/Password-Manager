using Domain;

namespace Presentation.Views
{
    public interface IAddCategoryView : IView
    {
        event EventHandler<Category> AddCategory; 
    }
}
