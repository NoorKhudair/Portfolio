using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Portfolio.Models;

namespace Portfolio.Data
{
    public class DataDbContext : IdentityDbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {
        }
        public DbSet<MasterAbout> MasterAbout { get; set; }

        public DbSet<MasterPositions> MasterPositions { get; set; }

        public DbSet<MasterSocialMedia> MasterSocialMedia { get; set; }

        public DbSet<MasterTitles> MasterTitles { get; set; }
    }
}
