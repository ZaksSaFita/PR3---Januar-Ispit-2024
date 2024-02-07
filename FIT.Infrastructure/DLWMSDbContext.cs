using FIT.Data;
using FIT.Data.IspitBrojIndeksa;
using Microsoft.EntityFrameworkCore;

using System.Configuration;

namespace FIT.Infrastructure
{
    public class DLWMSDbContext : DbContext
    {
        private readonly string dbPutanja;

        public DLWMSDbContext()
        {
            dbPutanja = ConfigurationManager.
                ConnectionStrings["DLWMSBaza"].ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }
    
        public DbSet<Student> Studenti { get; set; }
        public DbSet<DrzaveBrojIndeksa> DrzaveBrojIndeksa { get; set; }
        public DbSet<GradoviBrojIndeksa> GradoviBrojIndeksa { get; set; }
        public DbSet<PolozeniPredmetiBrojIndeksa> PolozeniPredmeti { get; set; }
        public DbSet<PredmetiBrojIndeksa> Predmeti { get; set; }
        public DbSet<SemestriBrojIndeksa> Semestri { get; set; }


    }
}