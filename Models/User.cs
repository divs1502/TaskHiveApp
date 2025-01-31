namespace TaskHiveSyncs.Models
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password_hash { get; set; }
        public string password_salt { get; set; }
        public bool is_active { get; set; }
        public DateTime created_at { get; set; }
    }

    public class UserLoginDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class UserResponseDto
    {
        public string Token { get; set; }
        public User User { get; set; }
    }
}
