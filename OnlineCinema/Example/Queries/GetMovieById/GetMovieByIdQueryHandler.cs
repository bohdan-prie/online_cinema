using LecturesProjectExample.Example.Dtos;
using OnlineCinema.Example.Context;
using OnlineCinema.Example.Core.Query;
using OnlineCinema.Example.Entities;
using OnlineCinema.Example.Queries.GetMovieById;
using System.Security.Cryptography.X509Certificates;

namespace OnlineCinema.Example.Queries.GetMovieById;

public sealed class GetMovieByIdQueryHandler : IQueryHandler<GetMovieByIdQuery, MovieDto>
{
    private readonly JournalContext _context;

    public GetMovieByIdQueryHandler(JournalContext context)
    {
        _context = context;
    }

    public async Task<MovieDto> Handle(GetMovieByIdQuery query)
    {
        IEnumerable<MovieEntity> movies = 
            from m in _context.Movies
                where m.Id == query.Id
                select m;

        MovieEntity movie = movies.First();
        return new MovieDto(movie.Id, movie.Title, movie.Price);
    }
}