using Portfolio.Models;
using System.Reflection;

namespace Portfolio.ViewModels
{
    public class CertificatesViewModel
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public string LogoURL { get; set; }
        public string Title { get; set; }
        public int MembershipNumber { get; set; }
        public DateTime Date { get; set; }
         public IFormFile? Logo { get; set; }
    }
}
