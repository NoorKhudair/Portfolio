namespace Portfolio.Models
{
    public class Experience : BaseEntity
    {
        public string Title { get; set; }
            public string   Desc { get; set; }
            public int StartYear { get; set; }
            public int? EndYear { get; set; }
            public string Place { get; set; }
        public bool IsEdu  { get; set; }
            public bool IsCurrent { get; set; }
    }
}
