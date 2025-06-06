namespace EduSyncBackend.DTOs
{
    public class RegisterUserDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; } // "Student" or "Instructor"
        public string Password { get; set; }
    }
}