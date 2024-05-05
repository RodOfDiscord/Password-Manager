using Domain;

namespace Infrastructure.Repositories
{
    public interface IProfileRepository : IBaseRepository<Profile>
    {
        IEnumerable<Profile> GetAllWithNotes();
        Profile? GetByName(string name);
        Profile? GetByNameWithNotes(string name);
        Profile? GetByNameWithAll(string name);
    }
}