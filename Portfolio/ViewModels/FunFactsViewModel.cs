namespace Portfolio.ViewModels
{
    public class FunFactsViewModel
    {

        public int Id { get; set; }
        public string IconURL { get; set; }
        public string Title { get; set; }
        public int Count { get; set; }
        public IFormFile? IconFile { get; set; }
        public bool IsActive { get; set; }
    }
}
