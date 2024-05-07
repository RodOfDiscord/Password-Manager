using Domain;
using Domain.Cipher;
using Presentation.Views;
using Services;

namespace Presentation.Presenters
{
    public class AddProfilePresenter : BasePresenter<IAddProfileView>
    {
        private readonly IProfileService profileService;
        private readonly IEncryptionService encryptionService;
        public event EventHandler? ProfileAdded;
        public AddProfilePresenter(IAddProfileView view, IProfileService profileService, IEncryptionService encryptionService) : base(view)
        {
            View.AddProfile += AddProfile;
            this.profileService = profileService;
            this.encryptionService = encryptionService;
        }

        private void AddProfile(object? sender, Profile profile)
        {
            profile.Password = encryptionService.Encrypt(profile.Password);
            profileService.Add(profile);
            ProfileAdded?.Invoke(this, EventArgs.Empty);
            View.Close();
        }
    }
}