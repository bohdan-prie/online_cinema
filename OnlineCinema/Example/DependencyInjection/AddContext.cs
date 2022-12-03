using OnlineCinema.Example.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace OnlineCinema.Example.DependencyInjection;

public static class AddContext
{
    public static IServiceCollection AddJournalContext(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<JournalContextDb>(options =>
        {
            options.UseSqlServer(connectionString);
        });

        return services;
    }
}