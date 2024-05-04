using Domain;
using Infrastructure.Repositories;

namespace Services
{
    public class ProfileService : IProfileService
    {
        IBaseRepository<Profile> repository;

        public ProfileService(IBaseRepository<Profile> repository)
        {
            this.repository = repository;
        }

        public Profile? FindByName(string name)
        {
            return repository.GetAll().FirstOrDefault(x => x.Name == name);
        }

        public IEnumerable<Profile> GetProfiles()
        {
            return repository.GetAll();
        }
    }
}
