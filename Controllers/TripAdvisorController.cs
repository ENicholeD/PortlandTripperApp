
using Microsoft.AspNetCore.Mvc;
using PortlandTripper.Models;

namespace PortlandTripper.Controllers
{
    public class TripAdvisorController : Controller
    {
        public IActionResult Index()
        {
            var allDestinations = TripAdvisor.GetTrips();
            System.Console.WriteLine(allDestinations);
            return View(allDestinations);
        }
    }
}