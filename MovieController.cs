
using Microsoft.AspNetCore.Mvc;
using OnlineMovieTicketBookingSystem.Data;
using OnlineMovieTicketBookingSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace OnlineMovieTicketBookingSystem.Controllers
{
    public class MovieController : Controller
    {
        private readonly ApplicationDbContext _context;
        public MovieController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string? industry, string? search)
        {
            var movies = _context.Movies.AsQueryable();
            if (!string.IsNullOrEmpty(industry))
            {
                if (industry.ToLower() == "bollywood") movies = movies.Where(m => m.Language.ToLower() == "hindi");
                if (industry.ToLower() == "tollywood") movies = movies.Where(m => m.Language.ToLower() == "telugu");
            }
            if (!string.IsNullOrEmpty(search))
            {
                movies = movies.Where(m => m.Title.Contains(search));
            }
            var list = await movies.OrderBy(m => m.ReleaseDate).ToListAsync();
            return View(list);
        }

        public async Task<IActionResult> Details(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie == null) return NotFound();
            return View(movie);
        }
    }
}
