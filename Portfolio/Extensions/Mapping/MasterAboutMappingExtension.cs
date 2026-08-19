using Portfolio.Models;
using Portfolio.ViewModels;

namespace Portfolio.Extensions.Mapping
{
    public static class MasterAboutMappingExtension
    {

        public static MasterAbout ToModel(this MasterAboutViewModel model)
        {
            return new MasterAbout
            {

                Id = model.Id,
                IsActive = model.IsActive,
                Address = model.Address,
                CVURL = model.CVURL,
                DateOfBirth = model.DateOfBirth,
                Email = model.Email,
                ImageURL = model.ImageURL,
                Name = model.Name,
                Phone = model.Phone,
                Country = model.Country,
                Desc = model.Desc,
            };


        }


        public static MasterAboutViewModel ToViewModel(this MasterAbout model)
        {
            return new MasterAboutViewModel
            {
                Id = model.Id,
                IsActive = model.IsActive,
                Address = model.Address,
                CVURL = model.CVURL,
                DateOfBirth = model.DateOfBirth,
                Email = model.Email,
                ImageURL = model.ImageURL,
                Name = model.Name,
                Phone = model.Phone,
                Country = model.Country,
                Desc = model.Desc,
                Age=DateTime.Now.Year-model.DateOfBirth.Year,
            };

        }
        public static List<MasterAboutViewModel> ToViewModelList(this List<MasterAbout> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }

        public static List<MasterAbout> ToModelList(this List<MasterAboutViewModel> model)
        {

            return model.Select(x => x.ToModel()).ToList();
        }
    }
}
