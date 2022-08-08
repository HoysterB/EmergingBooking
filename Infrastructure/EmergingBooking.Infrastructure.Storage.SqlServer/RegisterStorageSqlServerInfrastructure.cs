using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EmergingBooking.Infrastructure.Storage.SqlServer;

public static class RegisterStorageSqlServerInfrastructure
{
    public static IServiceCollection RegisterSqlServerInfrastructureDependencies(this IServiceCollection services,
        IConfiguration configuration)
    {
        SqlServerSettings ravenDbSettings = configuration.GetSection(nameof(SqlServerSettings)).Get<SqlServerSettings>();
        services.AddOptions<SqlServerSettings>();

        services.AddTransient<ISqlServerStorageHolder, SqlServerStoreHolder>();
        
        return services;
    }
}