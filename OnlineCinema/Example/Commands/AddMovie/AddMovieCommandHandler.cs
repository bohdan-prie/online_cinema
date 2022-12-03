using OnlineCinema.Example.Context;
using OnlineCinema.Example.Core.Command;
using OnlineCinema.Example.Entities;

namespace OnlineCinema.Example.Commands.AddMovie;

public sealed class AddMovieCommandHandler : ICommandHandler<AddMovieCommand>
{
    private readonly JournalContext _context;

    public AddMovieCommandHandler(JournalContext context)
    {
        _context = context;
    }

    public async Task Handle(AddMovieCommand command)
    {

        await _context.Insert(
            new MovieEntity(
                command.Id,
                command.Title,
                command.Price
                )
            );
    }
}