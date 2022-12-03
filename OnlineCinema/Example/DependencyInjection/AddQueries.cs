using OnlineCinema.Example.Dtos;
using OnlineCinema.Example.Core.Query;
using OnlineCinema.Example.Queries.GetMovieById;
using OnlineCinema.Example.Queries.GetUserById;
using OnlineCinema.Example.Queries.GetUserSubscriptionById;

namespace LecturesProjectExample.Example.DependencyInjection;

public static class AddQueries
{
    public static IServiceCollection AddAllQueries(this IServiceCollection services)
    {
        services
            .AddScoped<IQueryHandler<GetMovieByIdQuery, MovieDto>, GetMovieByIdQueryHandler>()
            .AddScoped<IQueryHandler<GetUserByIdQuery, UserDto>, GetUserByIdQueryHandler>()
            .AddScoped<IQueryHandler<GetUserSubscriptionByIdQuery, UserSubscriptionDto>, GetUserSubscriptionByIdQueryHandler>();

        return services;
    }
}