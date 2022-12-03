using OnlineCinema.Example.Core.Query;

namespace OnlineCinema.Example.Queries.GetUserSubscriptionById;

public sealed record GetUserSubscriptionByIdQuery : IQuery
{
    public string UserId { get; }

    public GetUserSubscriptionByIdQuery(string userId)
    {
        this.UserId = userId;
    }
}