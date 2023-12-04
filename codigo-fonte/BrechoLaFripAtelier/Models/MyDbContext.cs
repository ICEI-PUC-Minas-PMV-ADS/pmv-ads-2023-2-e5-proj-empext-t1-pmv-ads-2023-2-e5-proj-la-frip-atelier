using Microsoft.EntityFrameworkCore;

namespace BrechoLaFripAtelier.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet(null, DelegationModes.ApplyToDatabases);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Partner)
                .WithMany(p => p.Products)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Sale>()
                .HasOne(s => s.Product)
                .WithMany(p => p.Sales)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.ClientSetNull);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Admin> Admins { get; set; } = default!;
        public DbSet<Partner> Partners { get; set; } = default!;
        public DbSet<Product> Products { get; set; } = default!;
        public DbSet<Sale> Sales { get; set; } = default!;
    }
}
