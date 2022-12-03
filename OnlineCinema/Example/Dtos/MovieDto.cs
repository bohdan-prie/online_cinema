namespace LecturesProjectExample.Example.Dtos;

public sealed record MovieDto
{
    public string Id { get; }
    public string Title { get; }
    public decimal Price { get; }

    public MovieDto(string id, string title, decimal price)
    {
        this.Id = id;
        this.Title = title;
        this.Price = price;
    }
}