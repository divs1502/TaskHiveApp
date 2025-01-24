using Microsoft.EntityFrameworkCore;
using TaskHiveSyncs.Models;

namespace TaskHiveSyncs.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Make sure to use the correct case
            modelBuilder.Entity<User>().ToTable("users");  // Use quotes if necessary
            modelBuilder.Entity<Post>().ToTable("posts");  // Use quotes if necessary
        }
    }
}
