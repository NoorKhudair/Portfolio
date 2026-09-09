namespace Portfolio.ViewModels
{
    public class TestimonialsViewModel
    {

        public int Id { get; set; }
        
        public string ImageURL { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Position { get; set; }
        public string IconURL { get; set; }

        public bool IsActive { get; set; }
        public IFormFile? IconFile { get; set; }
        public IFormFile? ImageFile { get; set; }

    }
}
