using OnlineCinema.Example.Commands.AddMovie;
using OnlineCinema.Example.Core.Command;
using OnlineCinema.Models;
using Microsoft.AspNetCore.Mvc;

namespace LecturesProjectExample.Controllers.Movies
{
    public class AddNewMovieController : Controller
    {
        private readonly ICommandHandler<AddMovieCommand> _commandHandler;

        public AddNewMovieController(ICommandHandler<AddMovieCommand> commandHandler)
        {
            _commandHandler = commandHandler;
        }

        [HttpGet("/Insert")]
        public IActionResult AddMovie()
        {
            return View("../Movies/Index", new MovieItemViewModel());
        }

        [HttpPost("/AddMovie")]
        public async Task<IActionResult> AddMovie(MovieItemViewModel model)
        {
            await _commandHandler.Handle(new AddMovieCommand(
                Guid.NewGuid().ToString(),
                model.Title,
                model.Price
                )
            );

            return RedirectToAction("Index", "Home");
        }
    }
}
