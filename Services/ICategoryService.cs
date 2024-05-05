using Domain;

namespace Services
{
    public interface ICategoryService
    {
        void Add(Category category);
        IEnumerable<Category> GetAll();
    }
}