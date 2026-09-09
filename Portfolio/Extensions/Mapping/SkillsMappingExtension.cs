using Portfolio.Models;
using Portfolio.ViewModels;

namespace Portfolio.Extensions.Mapping
{
    public static class SkillsMappingExtension

    {

        public static Skills ToModel(this SkillsViewModel model)
        {
            return new Skills
            {

                Id = model.Id,
                IsActive = model.IsActive,
                SkillName = model.SkillName,
                Percentage = model.Percentage,
                SkillType = model.SkillType,


            };
        }


        public static SkillsViewModel ToViewModel(this Skills model)
        {
            return new SkillsViewModel
            {
                Id = model.Id,
                IsActive = model.IsActive,
                SkillName = model.SkillName,
                Percentage = model.Percentage,
                SkillType = model.SkillType,

            };

        }
        public static List<SkillsViewModel> ToViewModelList(this List<Skills> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }

        public static List<Skills> ToModelList(this List<SkillsViewModel> model)
        {

            return model.Select(x => x.ToModel()).ToList();
        }
    }
}
