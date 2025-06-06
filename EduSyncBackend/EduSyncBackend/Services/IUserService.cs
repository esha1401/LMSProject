//using EduSyncBackend.Models;

//namespace EduSyncBackend.Services
//{
//    /// <summary>
//    /// Service interface for user management operations including password hashing, verification, and JWT generation.
//    /// </summary>
//    public interface IUserService
//    {
//        /// <summary>
//        /// Hashes a plain text password securely.
//        /// </summary>
//        /// <param name="password">The plain text password.</param>
//        /// <returns>The hashed password string.</returns>
//        string HashPassword(string password);

//        /// <summary>
//        /// Verifies a plain text password against a hashed password.
//        /// </summary>
//        /// <param name="password">The plain text password.</param>
//        /// <param name="hash">The stored hashed password.</param>
//        /// <returns>True if the password matches; otherwise false.</returns>
//        bool VerifyPassword(string password, string hash);

//        /// <summary>
//        /// Generates a JWT token for an authenticated user.
//        /// </summary>
//        /// <param name="user">The authenticated user.</param>
//        /// <returns>The JWT token as a string.</returns>
//        string GenerateJwtToken(User user);

//        // Optional: Add methods like:
//        // User? GetUserByEmail(string email);
//        // Task<User> RegisterUser(User user, string password);
//    }
//}