namespace Portfolio.Models
{
    public class Certificates : BaseEntity
    {
       public string LogoURL { get; set; }
       public string Title { get; set; }
       public int MembershipNumber { get; set; }
       public DateTime Date { get; set; }
    }
}
