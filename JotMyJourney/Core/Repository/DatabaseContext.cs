using JotMyJourney.Models;
using Microsoft.EntityFrameworkCore;

namespace JotMyJourney.Core.Repository
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Journal> Journals { get; set; }

    }
}
