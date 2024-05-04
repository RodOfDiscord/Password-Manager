using Domain;
using Presentation.Views;
using Services;

namespace Presentation.Presenters
{
    public class ChooseProfilePresenter : BasePresenter<IChooseProfileView>
    {
        IProfileService profileService;
        List<Profile> profiles;
        BasePresenter<ILoginView> loginPresenter;
        public ChooseProfilePresenter(IChooseProfileView chooseProfileView, IProfileService profileService, BasePresenter<ILoginView> loginPresenter) : base(chooseProfileView)
        { 
            this.loginPresenter = loginPresenter;
            this.profileService = profileService;
            View.ProfileSelected += OnProfileSelected;
            profiles = profileService.GetProfiles().ToList();
        }        
        
        public override void Run()
        {
            View.DisplayProfiles(profileService.GetProfiles());
            View.Show();
        }

        public void OnProfileSelected(object? sender, string name)
        {
            var profile = profiles.FirstOrDefault(p => p.Name == name);
            if (profile == null)
            {
                MessageBox.Show("Profile not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            loginPresenter.View.SetProfile(profile);
            View.DisplayLoginUC((UserControl)loginPresenter.View);
        }
    }
}