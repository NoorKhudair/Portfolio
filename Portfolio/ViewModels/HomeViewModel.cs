namespace Portfolio.ViewModels
{
    public class HomeViewModel
    {
        public MasterAboutViewModel MasterAbout { get; set; }
        public List<MasterSocialMediaViewModel> MasterSocialMedia { get; set; }

        public List<MasterPositionsViewModel> MasterPositions { get; set; }

        public List<MasterTitleViewModel> MasterTitle { get; set; }

    }
}
