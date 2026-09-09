namespace Portfolio.Models
{
    public class Portfolios : BaseEntity
    {
        public string ThumbnailImage { get; set; }
            public string FullImage { get; set; }
            public string Title { get; set; }
            public int CategoriesId { get; set; }
    }
}
