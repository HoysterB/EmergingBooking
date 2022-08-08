using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EmergingBooking.Management.Application;

public static class RegisterManagementApplication
{
    public static IServiceCollection RegisterManagementApplicationDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
    }
}