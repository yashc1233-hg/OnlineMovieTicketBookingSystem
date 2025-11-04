
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMovieTicketBookingSystem.Models
{
    public class Booking
    {
        public int Id { get; set; }
        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public Movie? Movie { get; set; }
        public string? UserId { get; set; }
        public string ShowTime { get; set; } = string.Empty;
        public int SeatsBooked { get; set; }
        public DateTime BookingDate { get; set; } = DateTime.Now;
    }
}
