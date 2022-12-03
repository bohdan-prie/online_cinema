namespace OnlineCinema.Example.Data.Entities;

public record UserEntity
{
    public string Id { get; init; }
    public string Username { get; init; }
    public string Password { get; init; }


    public virtual UserPaymentInfoEntity UserPaymentInfo { get; init; }

    public UserEntity(string id, string username, string password)
    {
        this.Id = id;
        this.Username = username;
        this.Password = password;
    }
}
