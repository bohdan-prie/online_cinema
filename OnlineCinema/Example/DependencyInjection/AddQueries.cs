using LecturesProjectExample.Example.Dtos;
using OnlineCinema.Example.Core.Query;
using OnlineCinema.Example.Queries.GetMovieById;

namespace LecturesProjectExample.Example.DependencyInjection;

public static class AddQueries
{
    public static IServiceCollection AddMovieQueries(this IServiceCollection services)
    {
        services
            .AddScoped<IQueryHandler<GetMovieByIdQuery, MovieDto>, GetMovieByIdQueryHandler>();

        return services;
    }
}