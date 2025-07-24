using Microsoft.Extensions.DependencyInjection;
using PatronusR.Extensions;

namespace TestNugetPackage.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var assembly = typeof(DependencyInjection).Assembly;

            services.AddPatronusR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(assembly);
            });

            return services;
        }
    }

}
