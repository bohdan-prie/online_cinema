using OnlineCinema.Example.Dtos;
using OnlineCinema.Example.Data.Context;
using OnlineCinema.Example.Core.Query;
using OnlineCinema.Example.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace OnlineCinema.Example.Queries.GetUserById;

public sealed class GetUserByIdQueryHandler : IQueryHandler<GetUserByIdQuery, UserDto>
{
    private readonly JournalContextDb _context;

    public GetUserByIdQueryHandler(JournalContextDb context)
    {
        _context = context;
    }

    public async Task<UserDto?> Handle(GetUserByIdQuery query)
    {
        UserEntity? user = await _context.Users.FirstOrDefaultAsync(p => p.Id == query.Id);

        if (user == null)
        {
            return null;
        }

        return new UserDto
        {
            Id = user.Id,
            Username = user.Username
        };
    }
}