using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure
{
    public class PasswordStorageContext : DbContext
    {
        readonly IConfiguration configuration;

        public PasswordStorageContext(DbContextOptions<PasswordStorageContext> options, IConfiguration configuration)
            : base(options)
        {
            this.configuration = configuration;
        }

        public DbSet<Note> Notes { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(configuration.GetConnectionString("Default"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.ToTable("notes");

                entity.HasOne(e => e.Category)
                      .WithMany(c => c.Notes)
                      .HasForeignKey(e => e.CategoryId)
                      .IsRequired(false)
                      .OnDelete(DeleteBehavior.Cascade);
                entity.HasOne(p => p.Profile)
                      .WithMany(c => c.Notes)
                      .HasForeignKey(e => e.ProfileId)
                      .IsRequired()
                      .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.ToTable("categories");
            });

            modelBuilder.Entity<Profile>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.ToTable("profiles");
            });
        }
    }
}