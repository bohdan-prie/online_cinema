using OnlineCinema.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using OnlineCinema.Example.Data.Context;
using OnlineCinema.Example.Data.Entities;

namespace LecturesProjectExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly JournalContextDb _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(JournalContextDb context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            // use query here
            List<MovieItemViewModel> model = new List<MovieItemViewModel>();

            foreach (MovieEntity entity in _context.Movies)
            {
                model.Add(new MovieItemViewModel()
                {
                    Title = entity.Title,
                    Price = entity.Price,
                });
            }

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });

            User user = new User();
            IService<User> service = new UserService();
            Console.WriteLine(service.GetId(user));
        }
    }

    public interface IEntity { public string Id { get; } }
    public sealed class User : IEntity { public string Id => "1"; }

    public interface IService<TEntity> where TEntity : IEntity
    {
        public string GetId(TEntity entity)
        {
            return entity.Id;
        }
    }

    public sealed class UserService : IService<User> { }

}