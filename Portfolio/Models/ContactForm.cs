namespace Portfolio.Models
{
    public class ContactForm : BaseEntity
    {
        public string Name { get; set; }
            public string Email { get; set; }
            public string subject { get; set; }
            
            public string Message { get; set; }
    }
}
