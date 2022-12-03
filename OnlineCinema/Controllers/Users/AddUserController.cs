using OnlineCinema.Example.Commands.AddMovie;
using OnlineCinema.Example.Core.Command;
using OnlineCinema.Models;
using Microsoft.AspNetCore.Mvc;

namespace LecturesProjectExample.Controllers.Users
{
    public class AddUserController : Controller
    {
        private readonly ICommandHandler<AddUserCommand> _commandHandler;

        public AddUserController(ICommandHandler<AddUserCommand> commandHandler)
        {
            _commandHandler = commandHandler;
        }

        [HttpGet("/Insert")]
        public IActionResult AddUser()
        {
            return View("../Users/Index", new UserItemViewModel());
        }

        [HttpPost("/AddUser")]
        public async Task<IActionResult> AddUser(UserItemViewModel model)
        {
            await _commandHandler.Handle(new AddUserCommand(
                Guid.NewGuid().ToString(),
                model.Username,
                model.Password
                )
            );

            return RedirectToAction("Index", "Home");
        }
    }
}

