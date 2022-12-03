using OnlineCinema.Example.Data.Context;
using OnlineCinema.Example.Core.Command;
using OnlineCinema.Example.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace OnlineCinema.Example.Commands.AddMovie;

public sealed class AddMovieCommandHandler : ICommandHandler<AddMovieCommand>
{
    private readonly JournalContextDb _context;

    public AddMovieCommandHandler(JournalContextDb context)
    {
        _context = context;
    }

    public async Task Handle(AddMovieCommand command)
    {
        MovieEntity? movie = await _context.Movies.FirstOrDefaultAsync(p => p.Title == command.Title);

        if (movie != null)
        {
            return;
        }

        _context.Movies.Add(
            new MovieEntity(
                command.Id,
                command.Title,
                command.Price
                )
            );

        await _context.SaveChangesAsync();
    }
}