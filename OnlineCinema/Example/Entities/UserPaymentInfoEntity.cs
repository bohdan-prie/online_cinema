using System;

namespace OnlineCinema.Example.Entities;

public sealed record UserPaymentInfoEntity
{
    public string Id { get; }
    public string SubscriptionId {  get; }
    public DateTime ExpiresAt { get; }

    public UserPaymentInfoEntity(string id, string subscriptionId, DateTime expiresAt)
    {
        this.Id = id;
        this.SubscriptionId = subscriptionId;
        this.ExpiresAt = expiresAt;
    }
}
