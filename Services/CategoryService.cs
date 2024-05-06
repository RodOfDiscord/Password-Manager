using Domain;
using Infrastructure.Repositories;

namespace Services
{
    public class CategoryService : ICategoryService
    {
        private readonly BaseRepository<Category> categoryRepository;

        public CategoryService(BaseRepository<Category> categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public void Add(Category category)
        {
            if (category == null || category.Name == null)
            {
                throw new ArgumentNullException();
            }
            categoryRepository.Create(category);
        }

        public void Delete(Guid id)
        {
            categoryRepository.DeleteById(id);
        }

        public IEnumerable<Category> GetAll()
        {
            return categoryRepository.GetAll();
        }

        public Category? GetById(Guid id)
        {
            return categoryRepository.GetById(id);
        }

        public void Update(Category category)
        {
            categoryRepository.Update(category);
        }
    }
}
