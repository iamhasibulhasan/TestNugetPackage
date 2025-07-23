using TestNugetPackage.Application.Feature;
using TestNugetPackage.Application.Interface;

namespace TestNugetPackage.Infrastructure.Service
{
    public class UserService : IUserService
    {
        public async Task<User> GetAllUser()
        {
            return await Task.FromResult(new User
            {
                Id = 1,
                Name = "John Doe"
            });
        }
    }
}
