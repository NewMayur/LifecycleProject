using LifecycleLibrary;
using Microsoft.AspNetCore.Mvc;
using MVCLifeCycle.Models;
using System.Diagnostics;

namespace MVCLifeCycle.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SimpleDataAccess _dataAccess;

        public HomeController(ILogger<HomeController> logger, SimpleDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }

        public IActionResult Index()
        {
            var people = _dataAccess.LoadPeople();
            return View(people);
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
