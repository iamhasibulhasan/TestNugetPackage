using TestNugetPackage.Application.Feature;
using TestNugetPackage.Application.Interface;

namespace TestNugetPackage.Infrastructure.Service
{
    public class UserService : IUserService
    {
        public async Task<List<User>> GetAllUser()
        {
            var users = new List<User>
        {
            new User
            {
                Id = 1,
                Name = "John Doe",
                Email = "john.doe@example.com",
                CreatedAt = DateTime.Now.AddDays(-30),
                Role = "Admin",
                IsActive = true
            },
            new User
            {
                Id = 2,
                Name = "Jane Smith",
                Email = "jane.smith@example.com",
                CreatedAt = DateTime.Now.AddDays(-25),
                Role = "User",
                IsActive = true
            },
            new User
            {
                Id = 3,
                Name = "Bob Johnson",
                Email = "bob.johnson@example.com",
                CreatedAt = DateTime.Now.AddDays(-20),
                Role = "Moderator",
                IsActive = false
            },
            new User
            {
                Id = 4,
                Name = "Alice Brown",
                Email = "alice.brown@example.com",
                CreatedAt = DateTime.Now.AddDays(-15),
                Role = "User",
                IsActive = true
            },
            new User
            {
                Id = 5,
                Name = "Charlie Wilson",
                Email = "charlie.wilson@example.com",
                CreatedAt = DateTime.Now.AddDays(-10),
                Role = "User",
                IsActive = true
            }
        };

            return users;
        }
    }
}
