using OnlineCinema.Example.Core.Command;
using OnlineCinema.Example.Entities;

public class AddMovieCommand : ICommand
{
    public string Id { get; }
    public string Title { get; }
    public decimal Price { get; }

    public AddMovieCommand(string id, string title, decimal price)
	{
        this.Id = id;
        this.Title = title;
        this.Price = price;
    }
}
