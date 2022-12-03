using OnlineCinema.Example.Core.Command;

public class SubscribeUserCommand : ICommand
{
    public string UserId { get; }
    public string SubscriptionId { get; }

    public SubscribeUserCommand(string userId, string subscriptionId)
    {
        this.UserId = userId;
        this.SubscriptionId = subscriptionId;
    }
}
