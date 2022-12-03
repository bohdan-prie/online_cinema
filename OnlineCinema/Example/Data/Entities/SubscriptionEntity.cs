namespace OnlineCinema.Example.Data.Entities;

public record SubscriptionEntity
{
    public string Id { get; init; }
    public decimal Price { get; init; }
    public int DurationInMonth { get; init; }

    public virtual ICollection<UserPaymentInfoEntity> UserPaymentInfo { get; init; }


    public SubscriptionEntity(string id, decimal price, int durationInMonth)
    {
        this.Id = id;
        this.DurationInMonth = durationInMonth;
        this.Price = price;
    }
}
