using System.ComponentModel.DataAnnotations;

namespace ConnectWeb.Models
{
    public class Booking
    {
        [Key]
        public int bookingId { get; set; }
        [Required]
        public DateTime weekCommencing { get; set; }
        public int userId { get; set; }
        public User user { get; set; }
    }
}
