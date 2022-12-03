namespace OnlineCinema.Example.Entities;

public sealed record MovieEntity
{
    public string Id { get; }
    public string Title { get; }
    public decimal Price { get; }

    public MovieEntity(string id, string title, decimal price)
	{ 
        this.Id = id;
        this.Title = title;
        this.Price = price;
    }
}
