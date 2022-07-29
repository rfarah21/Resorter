using System.ComponentModel.DataAnnotations;

namespace Resort_Management.Models
{
    public class BookingModel
    {
        [Key]
        public int bookingId { get; set; }
        [Required]
        public int userbookedId { get; set; }
        [Required]
        public DateTime dateForBooking { get; set; }
    }
}
