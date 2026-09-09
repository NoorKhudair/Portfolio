namespace Portfolio.ViewModels
{
    public class ClientsViewModel
    {
        public int Id { get; set; }
        public string ImageURL { get; set; }
        public string Link { get; set; }
        public string altText { get; set; }
        public string TitleText { get; set; }

        public bool IsActive { get; set; }
        public IFormFile? ImageFile { get; set; }

    }
}
