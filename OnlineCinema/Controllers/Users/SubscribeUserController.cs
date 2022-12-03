using OnlineCinema.Example.Commands.AddMovie;
using OnlineCinema.Example.Core.Command;
using OnlineCinema.Models;
using Microsoft.AspNetCore.Mvc;

namespace OnlineCinema.Controllers.Users
{
    public class SubscribeUserController : Controller
    {
        private readonly ICommandHandler<SubscribeUserCommand> _commandHandler;

        public SubscribeUserController(ICommandHandler<SubscribeUserCommand> commandHandler)
        {
            _commandHandler = commandHandler;
        }

        [HttpGet("/Insert")]
        public IActionResult SubscribeUserdUser()
        {
            return View("../Users/Subscribe/Index", new SubscribeUserItemViewModel());
        }

        [HttpPost("/SubscribeUser")]
        public async Task<IActionResult> SubscribeUser(SubscribeUserItemViewModel model)
        {
            await _commandHandler.Handle(new SubscribeUserCommand(
                model.UserId,
                model.SubscriptionId
                )
            );

            return RedirectToAction("Index", "Home");
        }
    }
}

