namespace TaskHiveSyncs.Models
{
    public class Post
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public DateTime created_at { get; set; }

        public User user { get; set; }
    }
}
