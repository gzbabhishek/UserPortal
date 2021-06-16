using Microsoft.EntityFrameworkCore;

namespace UserPortal.API.Models
{
    public class AppDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = UserProfile.db;");
        }
        public DbSet<UserMaster> UserMasters { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserMaster>().HasData(
            new UserMaster() { UserId = 1, PCode = "HCL000", FirstName = "Admin", LastName = "Main", Email = "admin@test.com", IsActive = true }
            );
        }
    }
}
