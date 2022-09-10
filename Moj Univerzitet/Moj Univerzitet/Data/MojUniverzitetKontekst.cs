using Microsoft.EntityFrameworkCore;
using Moj_Univerzitet.Models;

namespace Moj_Univerzitet.Data
{
    public class MojUniverzitetKontekst: DbContext
    {
        public MojUniverzitetKontekst(DbContextOptions<MojUniverzitetKontekst> options) : base(options)
        {
        }

        public DbSet<Predmet> Predmeti { get; set; }
        public DbSet<Polaganje> Polaganja { get; set; }
        public DbSet<Student> Studenti { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Predmet>().ToTable("Predmet");
            modelBuilder.Entity<Polaganje>().ToTable("Polaganje");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}
