using Portfolio.Models;
using Portfolio.ViewModels;

namespace Portfolio.Extensions.Mapping
{
    public static class PricingPlanMappingExtension

    {

        public static PricingPlan ToModel(this PricingPlanViewModel model)
        {
            return new PricingPlan
            {

                Id = model.Id,
                IsActive = model.IsActive,
                Name = model.Name,
                Price = model.Price,
                Link = model.Link,
                hint = model.hint,
                PlanItems = model.PlanItems
            };


        }


        public static PricingPlanViewModel ToViewModel(this PricingPlan model)
        {
            return new PricingPlanViewModel
            {
                Id = model.Id,
                IsActive = model.IsActive,
                Name = model.Name,
                Price = model.Price,
                Link = model.Link,
                hint = model.hint,
                PlanItems = model.PlanItems
            };

        }
        public static List<PricingPlanViewModel> ToViewModelList(this List<PricingPlan> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }

        public static List<PricingPlan> ToModelList(this List<PricingPlanViewModel> model)
        {

            return model.Select(x => x.ToModel()).ToList();
        }
    }
}
