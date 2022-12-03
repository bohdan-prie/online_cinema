using OnlineCinema.Example.Data.Context;
using OnlineCinema.Example.Core.Command;
using OnlineCinema.Example.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace OnlineCinema.Example.Commands.AddMovie;

public sealed class AddUserCommandHandler : ICommandHandler<AddUserCommand>
{
    private readonly JournalContextDb _context;

    public AddUserCommandHandler(JournalContextDb context)
    {
        _context = context;
    }

    public async Task Handle(AddUserCommand command)
    {
        UserEntity? user = await _context.Users.FirstOrDefaultAsync(p => p.Username == command.Username);

        if (user != null)
        {
            return;
        }

        _context.Users.Add(
                    new UserEntity(
                        command.Id,
                        command.Username,
                        command.Password
                        )
                    );

        await _context.SaveChangesAsync();
    }
}