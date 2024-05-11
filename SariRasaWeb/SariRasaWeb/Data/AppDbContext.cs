using Microsoft.EntityFrameworkCore;
using SariRasaWeb.Models;

namespace SariRasaWeb.Data
{
    public class AppDbContext: DbContext
    {
        public IConfiguration _config { get; set; }
        public AppDbContext(IConfiguration config)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("DatabaseConnection"));
        }

        public DbSet<MCustomer> MCustomer { get; set; }
        public DbSet<MPromosi> MPromosi { get; set; }
        public DbSet<HistoryPoint> HistoryPoint { get; set; }

        public DbSet<SldPoint> SldPoint { get; set; }
    }
}
