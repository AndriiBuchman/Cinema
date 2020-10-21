using Microsoft.EntityFrameworkCore;
using Models;

namespace Cinema.Context
{
    public class CinemaContext : DbContext
    {
        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options)
        {
        }

        public DbSet<Films> Films { get; set; }
        public DbSet<ReservedPlaces> ReservedPlaces { get; set; }
        public DbSet<Customers> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Films>().ToTable("Films");
            modelBuilder.Entity<ReservedPlaces>().ToTable("ReservedPlaces");
            modelBuilder.Entity<Customers>().ToTable("Customers");
        }
    }
}
