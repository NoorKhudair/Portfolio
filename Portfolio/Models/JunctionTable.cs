namespace Portfolio.Models
{
    public class JunctionTable : BaseEntity
    {
        public int PlanItemsId { get; set; }
        public PlanItems? PlanItems { get; set; }
        public int PricingPlanId { get; set; }
        public PricingPlan? PricingPlan { get; set; }
    }
}
