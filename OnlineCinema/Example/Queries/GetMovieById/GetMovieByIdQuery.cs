using OnlineCinema.Example.Core.Query;

namespace OnlineCinema.Example.Queries.GetMovieById;

public sealed record GetMovieByIdQuery : IQuery
{
    public string Id { get; }

    public GetMovieByIdQuery(string id)
    {
        this.Id = id;
    }
}