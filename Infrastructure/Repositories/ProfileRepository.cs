using Domain;

namespace Infrastructure.Repositories
{
    public class ProfileRepository : IRepository<Profile, Guid>
    {
        private readonly PasswordStorageContext context;

        public ProfileRepository(PasswordStorageContext context) 
        {
            this.context = context;
        }

        public Profile Create(Profile entity)
        {
            context.Profiles.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public Profile Delete(Profile entity)
        {
            context.Profiles.Remove(entity);
            context.SaveChanges();
            return entity;
        }

        public IEnumerable<Profile> GetAll()
        {
            return context.Profiles;
        }

        public Profile? GetById(Guid id)
        {
            return context.Profiles.FirstOrDefault(p => p.Id == id);
        }

        public Profile Update(Profile entity)
        {
            context.Update(entity);
            return entity;
        }
    }
}
