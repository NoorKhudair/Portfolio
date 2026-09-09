namespace Portfolio.Models
{
    public class Skills : BaseEntity
    {
        public string SkillName { get; set; }
            public int? Percentage { get; set; }
            public string SkillType { get; set; }
    }
}
