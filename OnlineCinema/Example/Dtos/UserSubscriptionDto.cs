namespace OnlineCinema.Example.Dtos;

public sealed record UserSubscriptionDto
{
    public string Id { get; init; }
    public string UserId { get; init; }
    public DateTime ExpiresAt { get; init; }
    public decimal Price { get; init; }
    public int DurationInMonth { get; init; }
}
