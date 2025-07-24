using Microsoft.Extensions.DependencyInjection;
using PatronusR.Extensions;
using System.Reflection;

namespace TestNugetPackage.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddPatronusR(Assembly.GetExecutingAssembly());
            return services;
        }
    }

}
