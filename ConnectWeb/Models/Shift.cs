using System.ComponentModel.DataAnnotations;

namespace ConnectWeb.Models
{
    public class Shift
    {
        [Key]
        public int ShiftId { get; set; }
        [Required]
        public int BookingId { get; set; }
        public Booking booking { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }
        [Required]
        public int ClientId { get; set; }
        public Client client { get; set; }
        [Required]
        public int RateTypeId { get; set; }
        public RateType rateType { get; set; }
        [Required]
        public int ReasonCodeId { get; set; }
        public ReasonCode ReasonCode { get; set; }
    }
}
