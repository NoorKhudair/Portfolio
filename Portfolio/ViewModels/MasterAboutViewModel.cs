namespace Portfolio.ViewModels
{
    public class MasterAboutViewModel
    {

        public int Id { get; set; }
        public bool IsActive { get; set; }

        public string Name { get; set; }
        public string? ImageURL { get; set; }
        public string? CVURL { get; set; }

        public string Desc { get; set; }

        public string Country { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public IFormFile? ImageFile { get; set; }
        public IFormFile?   CVFile { get; set; }
    }
}
