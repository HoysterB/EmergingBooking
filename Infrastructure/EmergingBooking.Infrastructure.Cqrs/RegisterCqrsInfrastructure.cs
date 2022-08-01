using EmergingBooking.Infrastructure.Cqrs.Commands;
using EmergingBooking.Infrastructure.Cqrs.Events;
using EmergingBooking.Infrastructure.Cqrs.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace EmergingBooking.Infrastructure.Cqrs;

public static class RegisterCqrsInfrastructure
{
    public static IServiceCollection RegisterInfrastructureCqrsDependencies(this IServiceCollection services)
    {
        services.AddSingleton<DependencyResolver>();
        
        services.AddSingleton<ICommandDispatcher, CommandDispatcher>();
        services.AddSingleton<IQueryProcessor, QueryProcessor>();
        services.AddSingleton<IEventPublisher, EventPublisher>();

        return services;
    }
}