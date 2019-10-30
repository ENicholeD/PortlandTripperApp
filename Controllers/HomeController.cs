using Microsoft.AspNetCore.Mvc;
using PortlandTripper.Models;

namespace PortlandTripper.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var allTrips = TripAdvisor.GetTrips();
            return View(allTrips);
          
        }
    }
}