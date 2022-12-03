using OnlineCinema.Example.Entities;

namespace OnlineCinema.Example.Context;

public sealed class JournalContext
{
    private readonly List<MovieEntity> _movies;

    public IEnumerable<MovieEntity> Movies => _movies;


    public JournalContext()
    {
        _movies = new List<MovieEntity>();
    }

    public Task Insert(MovieEntity entity)
    {
        return Task.Run(() => _movies.Add(entity));
    }
}