namespace Portfolio.Models
{
    public class MasterAbout : BaseEntity
    {
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public string CVURL { get; set; }

        public string Desc { get; set; }

        public string Country { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
        

        public DateTime DateOfBirth { get; set; }

    }
}
