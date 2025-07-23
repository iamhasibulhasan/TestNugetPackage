using TestNugetPackage.Application.Feature;

namespace TestNugetPackage.Application.Interface
{
    public interface IUserService
    {
        Task<User> GetAllUser();
    }
}
