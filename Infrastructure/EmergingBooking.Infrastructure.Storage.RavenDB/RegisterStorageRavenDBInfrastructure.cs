using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
 
namespace EmergingBooking.Infrastructure.Storage.RavenDB;

public static class RegisterStorageRavenDbInfrastructure
{
    public static IServiceCollection RegisterRavenDbStorageInfrastructureDependencies(this IServiceCollection services,
        IConfiguration configuration)
    {
        RavenDbSettings ravenDbSettings = configuration.GetSection(nameof(RavenDbSettings)).Get<RavenDbSettings>();
        services.AddOptions<RavenDbSettings>();

        services.AddTransient<IRavenDocumentStoreHolder, RavenDocumentStoreHolder>();
        
        return services;
    }
}