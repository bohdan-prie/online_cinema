namespace OnlineCinema.Example.Data.Entities;

public record MovieEntity
{
    public string Id { get; init; }
    public string Title { get; init; }
    public decimal Price { get; init; }


    public MovieEntity(string id, string title, decimal price)
	{ 
        this.Id = id;
        this.Title = title;
        this.Price = price;
    }
}
