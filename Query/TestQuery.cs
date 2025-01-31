using GraphQL;
using TaskHiveSyncs.Data;
using TaskHiveSyncs.Models;

namespace TaskHiveSyncs.Query
{
    public class TestQuery
    {
        public async Task<IQueryable<User>> GetUsers([Service] ApplicationDbContext dbContext)
        {
            return dbContext.users.AsQueryable();
        }

        public async Task<IQueryable<Post>> GetPosts([Service] ApplicationDbContext dbContext)
        {
            return dbContext.posts.AsQueryable();
        }

        [Authorize]
        public string GetSecureData()
        {
            return "This is secure data only accessible by authenticated users!";
        }
    }
}
