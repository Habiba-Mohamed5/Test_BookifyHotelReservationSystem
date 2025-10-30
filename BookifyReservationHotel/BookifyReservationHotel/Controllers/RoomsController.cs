using Microsoft.AspNetCore.Mvc;

namespace BookifyReservationHotel.Controllers
{
    public class RoomsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            return View();
        }
    }
}