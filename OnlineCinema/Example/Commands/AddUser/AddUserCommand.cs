using OnlineCinema.Example.Core.Command;

public class AddUserCommand : ICommand
{
    public string Id { get; }
    public string Username { get; }
    public string Password { get; }

    public AddUserCommand(string id, string username, string password)
    {
        this.Id = id;
        this.Username = username;
        this.Password = password;
    }
}
