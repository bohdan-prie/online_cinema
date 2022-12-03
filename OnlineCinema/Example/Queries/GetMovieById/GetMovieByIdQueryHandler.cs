using OnlineCinema.Example.Dtos;
using OnlineCinema.Example.Data.Context;
using OnlineCinema.Example.Core.Query;
using OnlineCinema.Example.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace OnlineCinema.Example.Queries.GetMovieById;

public sealed class GetMovieByIdQueryHandler : IQueryHandler<GetMovieByIdQuery, MovieDto>
{
    private readonly JournalContextDb _context;

    public GetMovieByIdQueryHandler(JournalContextDb context)
    {
        _context = context;
    }

    public async Task<MovieDto> Handle(GetMovieByIdQuery query)
    {
        MovieEntity? movie = await _context.Movies.FirstOrDefaultAsync(p => p.Id == query.Id);

        if (movie == null)
        {
            return new MovieDto();
        }

        return new MovieDto { 
            Id = movie.Id,
            Title = movie.Title,
            Price = movie.Price 
        };
    }
}