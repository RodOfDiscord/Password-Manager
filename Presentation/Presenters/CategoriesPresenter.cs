using Domain;
using Presentation.Views;
using Services;

namespace Presentation.Presenters
{
    public class CategoriesPresenter : BasePresenter<ICategoriesView>
    {
        private readonly AddCategoryPresenter addCategoryPresenter;
        private readonly ICategoryService categoryService;
        public event EventHandler? CategoriesChanged;
        public CategoriesPresenter(ICategoriesView view, AddCategoryPresenter addCategoryPresenter, ICategoryService categoryService) : base(view)
        {
            this.addCategoryPresenter = addCategoryPresenter;
            this.categoryService = categoryService;
            View.PopulateCategories(categoryService.GetAll().ToList());
            View.UpdateCategory += UpdateCategory;
            View.DeleteCategory += DeleteCategory;
            View.AddCategory += AddCategory;
            addCategoryPresenter.CategoryAdded += (o, e) => { RefreshData(); };
        }

        private void AddCategory(object? sender, EventArgs e)
        {
            addCategoryPresenter.Run();
        }

        private void DeleteCategory(object? sender, Guid e)
        {
            categoryService.Delete(e);
            RefreshData();
            CategoriesChanged?.Invoke(this, EventArgs.Empty);
        }

        private void UpdateCategory(object? sender, (Guid, string) idWithName)
        {
            Category? category = categoryService.GetById(idWithName.Item1);
            if (category != null)
            {
                category.Name = idWithName.Item2;
                categoryService.Update(category);
                CategoriesChanged?.Invoke(this, EventArgs.Empty);
            }
            RefreshData();

        }

        private void RefreshData()
        {
            View.ClearTable();
            View.PopulateCategories(categoryService.GetAll().ToList());
        }
    }
}
