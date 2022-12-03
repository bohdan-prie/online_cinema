using OnlineCinema.Example.Context;

namespace OnlineCinema.Example.DependencyInjection;

public static class AddContext
{
    public static IServiceCollection AddJournalContext(this IServiceCollection services)
    {
        services.AddSingleton<JournalContext>();

        return services;
    }
}