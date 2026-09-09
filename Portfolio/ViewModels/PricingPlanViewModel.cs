using Portfolio.Models;

namespace Portfolio.ViewModels
{
    public class PricingPlanViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int Price { get; set; }
        public string Link { get; set; }
        public string hint { get; set; }

        public ICollection<PlanItems> PlanItems { get; set; }

        public bool IsActive { get; set; }
    }
}
