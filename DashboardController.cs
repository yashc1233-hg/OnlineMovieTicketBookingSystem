
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace OnlineMovieTicketBookingSystem.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _db;
        public DashboardController(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            // Basic counts - safe if tables exist
            int movies = 0;
            int bookings = 0;
            try {
                movies = await _db.Movies.CountAsync();
            } catch { }
            try {
                bookings = await _db.Bookings.CountAsync();
            } catch { }

            ViewBag.MoviesCount = movies;
            ViewBag.BookingsCount = bookings;
            return View();
        }
    }
}
