namespace Portfolio.ViewModels
{
    public class ExperienceViewModel
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public int StartYear { get; set; }
        public int? EndYear { get; set; }
        public string Place { get; set; }
        public bool IsEdu { get; set; }
        public bool IsCurrent { get; set; }
    }
}
