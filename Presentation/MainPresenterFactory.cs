using Domain;
using Microsoft.Extensions.DependencyInjection;
using Presentation.Presenters;
using Presentation.Views;
using Services;

namespace Presentation
{
    public class MainPresenterFactory : IMainPresenterFactory
    {
        IServiceProvider serviceProvider;

        public MainPresenterFactory(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public MainPresenter Create(Profile profile)
        {
            IMainView view = serviceProvider.GetRequiredService<IMainView>();
            EditNotePresenter editNotePresenter = serviceProvider.GetRequiredService<EditNotePresenter>();
            AddNotePresenter addNotePresenter = serviceProvider.GetRequiredService<AddNotePresenter>();
            CategoriesPresenter categoriesPresenter = serviceProvider.GetRequiredService<CategoriesPresenter>();
            INoteService noteService = serviceProvider.GetRequiredService<INoteService>();
            MainPresenter mainPresenter = new MainPresenter(view, editNotePresenter, addNotePresenter, categoriesPresenter, noteService, profile);
            return mainPresenter;
        }
    }
}
