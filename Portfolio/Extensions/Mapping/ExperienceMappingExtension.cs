using Portfolio.Models;
using Portfolio.ViewModels;

namespace Portfolio.Extensions.Mapping
{
    public static class ExperienceMappingExtension

    {

        public static Experience ToModel(this ExperienceViewModel model)
        {
            return new Experience
            {

                Id = model.Id,
                IsActive = model.IsActive,
               Title = model.Title,
                Desc = model.Desc,
                StartYear = model.StartYear,
                EndYear = model.EndYear,
                Place = model.Place,
                IsEdu = model.IsEdu,
                IsCurrent = model.IsCurrent
            };


        }


        public static ExperienceViewModel ToViewModel(this Experience model)
        {
            return new ExperienceViewModel
            {
                Id = model.Id,
                IsActive = model.IsActive,
                Title = model.Title,
                Desc = model.Desc,
                StartYear = model.StartYear,
                EndYear = model.EndYear,
                Place = model.Place,
                IsEdu = model.IsEdu,
                IsCurrent = model.IsCurrent
            };

        }
        public static List<ExperienceViewModel> ToViewModelList(this List<Experience> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }

        public static List<Experience> ToModelList(this List<ExperienceViewModel> model)
        {

            return model.Select(x => x.ToModel()).ToList();
        }
    }
}
