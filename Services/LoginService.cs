using Domain;
using Domain.Cipher;

namespace Services
{
    public class LoginService : ILoginService
    {
        IProfileService profileService;
        IEncryptionService encryptionService;

        public LoginService(IProfileService profileService, IEncryptionService encryptionService)
        {
            this.profileService = profileService;
            this.encryptionService = encryptionService;
        }

        public bool Login(string name, string inputPassword)
        {
            Profile? profile = profileService.FindByName(name) ?? throw new NullReferenceException();
            string password = encryptionService.Decrypt(profile.Password);
            if (inputPassword != password)
            {
                return false;
            }

            return true;
        }
    }
}
