using OnlineCinema.Example.Commands.AddMovie;
using OnlineCinema.Example.Core.Command;

namespace OnlineCinema.Example.DependencyInjection;

public static class AddCommands
{
    public static IServiceCollection AddMovieCommands(this IServiceCollection services)
    {
        services.AddScoped<ICommandHandler<AddMovieCommand>, AddMovieCommandHandler>();

        return services;
    }
}