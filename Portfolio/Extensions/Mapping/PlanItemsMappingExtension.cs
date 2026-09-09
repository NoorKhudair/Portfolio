using Portfolio.Models;
using Portfolio.ViewModels;

namespace Portfolio.Extensions.Mapping
{
    public static class PlanItemsMappingExtension

    {

        public static PlanItems ToModel(this PlanItemsViewModel model)
        {
            return new PlanItems
            {

                Id = model.Id,
                IsActive = model.IsActive,
                Desc = model.Desc,
            };


        }


        public static PlanItemsViewModel ToViewModel(this PlanItems model)
        {
            return new PlanItemsViewModel
            {
                Id = model.Id,
                IsActive = model.IsActive,
                Desc = model.Desc,
            };

        }
        public static List<PlanItemsViewModel> ToViewModelList(this List<PlanItems> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }

        public static List<PlanItems> ToModelList(this List<PlanItemsViewModel> model)
        {

            return model.Select(x => x.ToModel()).ToList();
        }
    }
}
