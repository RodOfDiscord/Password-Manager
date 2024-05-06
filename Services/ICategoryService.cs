using Domain;

namespace Services
{
    public interface ICategoryService
    {
        void Add(Category category);
        void Delete(Guid id);
        void Update(Category category);
        Category? GetById(Guid id);
        IEnumerable<Category> GetAll();
    }
}