
using Microsoft.AspNetCore.Mvc;
using OnlineMovieTicketBookingSystem.Data;
using OnlineMovieTicketBookingSystem.Models;

namespace OnlineMovieTicketBookingSystem.Controllers
{
    public class BookingController : Controller
    {
        private readonly ApplicationDbContext _context;
        public BookingController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Create(int movieId)
        {
            var movie = _context.Movies.Find(movieId);
            if (movie == null) return NotFound();
            ViewBag.MovieTitle = movie.Title;
            return View(new Booking { MovieId = movieId });
        }

        [HttpPost]
        public IActionResult Create(Booking booking)
        {
            if (ModelState.IsValid)
            {
                booking.BookingDate = DateTime.Now;
                _context.Bookings.Add(booking);
                _context.SaveChanges();
                TempData["Message"] = "Booking confirmed!";
                return RedirectToAction("Index", "Movie");
            }
            return View(booking);
        }
    }
}
