
using System.ComponentModel.DataAnnotations;

namespace OnlineMovieTicketBookingSystem.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public string Language { get; set; } = string.Empty;
        public DateTime ReleaseDate { get; set; }
        public string PosterUrl { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
