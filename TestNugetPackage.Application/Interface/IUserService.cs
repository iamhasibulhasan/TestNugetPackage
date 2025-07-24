using TestNugetPackage.Application.Feature;

namespace TestNugetPackage.Application.Interface
{
    public interface IUserService
    {
        Task<List<User>> GetAllUser();
    }
}
