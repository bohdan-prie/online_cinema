using OnlineCinema.Example.Core.Query;

namespace OnlineCinema.Example.Queries.GetUserById;

public sealed record GetUserByIdQuery : IQuery
{
    public string Id { get; }

    public GetUserByIdQuery(string id)
    {
        this.Id = id;
    }
}