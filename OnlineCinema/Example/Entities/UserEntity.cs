namespace OnlineCinema.Example.Entities;

public sealed record UserEntity
{
    public string Id { get; }
    public string Username { get; }
    public decimal Password { get; }

    public UserEntity(string id, string username decimal password)
    {
        this.Id = id;
        this.Username = username;
        this.Password = password;
    }
}
