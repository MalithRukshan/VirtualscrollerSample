using Microsoft.EntityFrameworkCore;
using VirtualscrollerSample.Model;

namespace VirtualscrollerSample
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }

        public DbSet<Patient> Patients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasKey(e => e.Oid);
                entity.ToTable("HealthCare_Patient");
            });

        }


    }
}

