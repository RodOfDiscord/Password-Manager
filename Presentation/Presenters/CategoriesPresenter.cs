using Domain;
using Presentation.Views;
using Services;

namespace Presentation.Presenters
{
    public class CategoriesPresenter : BasePresenter<ICategoriesView>
    {
        private readonly ICategoryService categoryService;
        public event EventHandler? CategoriesChanged;
        public CategoriesPresenter(ICategoriesView view, ICategoryService categoryService) : base(view)
        {
            this.categoryService = categoryService;
            View.PopulateCategories(categoryService.GetAll().ToList());
            View.UpdateCategory += UpdateCategory;
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
