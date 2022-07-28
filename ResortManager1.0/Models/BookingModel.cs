using System.ComponentModel.DataAnnotations;

namespace Resort_Management.Models
{
    public class BookingModel
    {
        [Key]
        public int bookingId { get; set; }
        [Required]
        public int userbookedId { get; set; }
        public DateTime dateBooked { get; set; } = DateTime.Now;
        [Required]
        public DateTime dateForBooking { get; set; }
    }
}
