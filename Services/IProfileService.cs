using Domain;

namespace Services
{
    public interface IProfileService
    {
        IEnumerable<Profile> GetProfiles();
        Profile? FindByName(string name);
        Profile? FindByNameWithNotes(string name);
        Profile? FindByNameWithAll(string name);
        void Add(Profile profile);
    }
}
