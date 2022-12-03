namespace OnlineCinema.Example.Entities;

public sealed record WatchedMovieEntity
{
    public string Id { get; }
    public string UserId { get; }
    public long StoppedAtSecond { get; }

    public WatchedMovieEntity(string id, string userId, long stoppedAtSecond)
    {
        this.Id = id;
        this.UserId = userId;
        this.StoppedAtSecond = stoppedAtSecond;
    }
}
