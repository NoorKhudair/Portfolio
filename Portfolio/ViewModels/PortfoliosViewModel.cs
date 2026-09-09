
namespace Portfolio.ViewModels
{
    public class PortfoliosViewModel
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public string ThumbnailImage { get; set; }
        public string FullImage { get; set; }
        public string Title { get; set; }
        public int CategoriesId { get; set; }
        public IFormFile? Thumbnail { get; set; }
        public IFormFile? Full { get; set; }
    }
}
