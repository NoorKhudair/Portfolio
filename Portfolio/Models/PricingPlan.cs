namespace Portfolio.Models
{
    public class PricingPlan : BaseEntity
    {
        public string Name { get; set; }
            public int Price { get; set; }
        public string Link { get; set; }
        public string hint { get; set; }

        public ICollection<PlanItems> PlanItems { get; set; }

    }
}
