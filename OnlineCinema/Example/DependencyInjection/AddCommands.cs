using OnlineCinema.Example.Commands.AddMovie;
using OnlineCinema.Example.Core.Command;

namespace OnlineCinema.Example.DependencyInjection;

public static class AddCommands
{
    public static IServiceCollection AddAllCommands(this IServiceCollection services)
    {
        services
            .AddScoped<ICommandHandler<AddMovieCommand>, AddMovieCommandHandler>()
            .AddScoped<ICommandHandler<AddUserCommand>, AddUserCommandHandler>()
            .AddScoped<ICommandHandler<SubscribeUserCommand>, SubscribeUserCommandHandler>();

        return services;
    }
}