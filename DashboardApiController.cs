
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace OnlineMovieTicketBookingSystem.Controllers
{
    [Route("api/dashboard")]
    [ApiController]
    public class DashboardApiController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public DashboardApiController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet("metrics")]
        public async Task<IActionResult> Metrics()
        {
            int movies = 0;
            int bookings = 0;
            try { movies = await _db.Movies.CountAsync(); } catch { }
            try { bookings = await _db.Bookings.CountAsync(); } catch { }

            // simple simulated online users
            var metrics = new {
                movies = movies,
                bookings = bookings,
                onlineUsers = System.DateTime.UtcNow.Second % 20 + 1
            };
            return Ok(metrics);
        }
    }
}
