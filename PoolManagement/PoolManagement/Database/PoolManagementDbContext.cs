using Microsoft.EntityFrameworkCore;
using PoolManagement.Database.DbModels;

namespace PoolManagement.Database
{
    public class PoolManagementDbContext : DbContext
    {
        public PoolManagementDbContext(DbContextOptions<PoolManagementDbContext> options) : base(options) { }

        public DbSet<Trainer> Trainers { get; set; }
        
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Trainer>(t =>
            {
                t.HasKey(t => t.ID_Trainer);
                t.Property(t => t.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Student>(s =>
            {
                s.HasKey(s => s.ID_Student);
                s.Property(s => s.Name).HasMaxLength(50);
                s.Property(s => s.Email).HasMaxLength(50);
                s.Property(s => s.Category).HasMaxLength(10);
            });

        }
    }

}
