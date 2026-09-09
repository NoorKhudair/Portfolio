namespace Portfolio.Models
{
    public class Clients: BaseEntity
    {
        public string ImageURL {  get; set; }
        public string Link { get; set; }
        public string altText { get; set; }


        public string TitleText { get; set; }

    }
}
