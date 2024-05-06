using Domain;

namespace Presentation.Views
{
    public interface ICategoriesView : IView
    {
        event EventHandler<Guid> DeleteCategory;
        event EventHandler<(Guid, string)> UpdateCategory;
        public void PopulateCategories(List<Category> categories);
        public void ClearTable();
    }
}