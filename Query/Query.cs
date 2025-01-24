using TaskHiveSyncs.Data;
using TaskHiveSyncs.Models;

namespace TaskHiveSyncs.Query
{
    public class Query
    {
        public async Task<IQueryable<User>> GetUsers([Service] ApplicationDbContext dbContext)
        {
            return dbContext.Users.AsQueryable();
        }

        public async Task<IQueryable<Post>> GetPosts([Service] ApplicationDbContext dbContext)
        {
            return dbContext.Posts.AsQueryable();
        }
    }
}
