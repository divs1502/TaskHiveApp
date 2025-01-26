﻿namespace TaskHiveSyncs.Models
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public DateTime created_at { get; set; }

        public ICollection<Post> posts { get; set; }
    }
}
