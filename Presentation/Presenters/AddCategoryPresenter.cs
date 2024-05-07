using Domain;
using Presentation.Views;
using Services;

namespace Presentation.Presenters
{
    public class AddCategoryPresenter : BasePresenter<IAddCategoryView>
    {
        private readonly ICategoryService categoryService;
        public event EventHandler? CategoryAdded;
        public AddCategoryPresenter(IAddCategoryView view, ICategoryService categoryService) : base(view)
        {
            this.categoryService = categoryService;
            View.AddCategory += OnAddCategory;
        }

        private void OnAddCategory(object? sender, Category category)
        {
            categoryService.Add(category);
            CategoryAdded?.Invoke(this, EventArgs.Empty);
            View.Close();
        }
    }
}
