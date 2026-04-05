using CleanUserApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanUserApp.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users => Set<User>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("Users");

                entity.HasKey(x => x.Id);

                entity.Property(x => x.FirstName)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(x => x.LastName)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(x => x.Age)
                      .IsRequired();
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}