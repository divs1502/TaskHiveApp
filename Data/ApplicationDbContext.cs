using Microsoft.EntityFrameworkCore;
using TaskHiveSyncs.Models;

namespace TaskHiveSyncs.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> users { get; set; }
        public DbSet<Post> posts { get; set; }

    }
}
