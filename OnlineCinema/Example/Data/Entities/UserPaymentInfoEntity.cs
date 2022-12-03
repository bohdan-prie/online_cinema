using System;

namespace OnlineCinema.Example.Data.Entities;

public record UserPaymentInfoEntity
{
    public string Id { get; init; }
    public string UserId { get; init; }
    public string SubscriptionId { get; set; }
    public DateTime ExpiresAt { get; set; }

    
    public virtual SubscriptionEntity Subscription { get; init; }
    public virtual UserEntity User { get; init; }

    public UserPaymentInfoEntity(string id, string subscriptionId, DateTime expiresAt)
    {
        this.Id = id;
        this.UserId = id;
        this.SubscriptionId = subscriptionId;
        this.ExpiresAt = expiresAt;
    }
}
