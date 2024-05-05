using Domain;
using Infrastructure.Repositories;

namespace Services
{
    public class ProfileService : IProfileService
    {
        IProfileRepository repository;

        public ProfileService(IProfileRepository repository)
        {
            this.repository = repository;
        }

        public Profile? FindByName(string name)
        {
            return repository.GetByName(name);
        }

        public IEnumerable<Profile> GetProfiles()
        {
            return repository.GetAll();
        }

        public Profile? FindByNameWithNotes(string name)
        {
            return repository.GetByNameWithNotes(name);
        }

        public Profile? FindByNameWithAll(string name)
        {
            return repository.GetByNameWithAll(name);
        }
    }
}