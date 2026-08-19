using Portfolio.Models;
using Portfolio.ViewModels;

namespace Portfolio.Extensions.Mapping
{
    public static class MasterSocialMediaMappingExtension
    {
        public static MasterSocialMedia ToModel(this MasterSocialMediaViewModel model)
        {
            return new MasterSocialMedia
            {

                Id = model.Id,
                IsActive = model.IsActive,
                Icon = model.Icon,
                Name = model.Name,
                Link = model.Link,

            };


        }


        public static MasterSocialMediaViewModel ToViewModel(this MasterSocialMedia model)
        {
            return new MasterSocialMediaViewModel
            {
                Id = model.Id,
                IsActive = model.IsActive,
                Icon = model.Icon,
                Name = model.Name,
                Link = model.Link,

            };

        }
        public static List<MasterSocialMediaViewModel> ToViewModelList(this List<MasterSocialMedia> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }

        public static List<MasterSocialMedia> ToModelList(this List<MasterSocialMediaViewModel> model)
        {

            return model.Select(x => x.ToModel()).ToList();
        }
    }
}
