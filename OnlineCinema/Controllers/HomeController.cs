using OnlineCinema.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using OnlineCinema.Example.Context;
using OnlineCinema.Example.Entities;

namespace LecturesProjectExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly JournalContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(JournalContext context, ILogger<HomeController> logger)
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
        }
    }
}