using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace Portfolio.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
       
        public bool IsActive { get; set; }
        public string? CreatedBy { get; set; }
        public string? EditedBy { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? EditedAt { get; set; }


    }
}
