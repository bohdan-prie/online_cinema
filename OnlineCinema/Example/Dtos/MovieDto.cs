namespace OnlineCinema.Example.Dtos;

public sealed record MovieDto
{
    public string Id { get; init; }
    public string Title { get; init; }
    public decimal Price { get; init; }
}