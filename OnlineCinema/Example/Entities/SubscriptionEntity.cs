namespace OnlineCinema.Example.Entities;

public sealed record SubscriptionEntity
{
    public string Id { get; }
    public decimal Price { get; }
    public int DurationInMonth { get; }

    public SubscriptionEntity(string id, decimal price, int durationInMonth)
    {
        this.Id = id;
        this.DurationInMonth = durationInMonth;
        this.Price = price;
    }
}
