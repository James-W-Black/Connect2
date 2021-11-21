using System.ComponentModel.DataAnnotations;

namespace ConnectWeb.Models
{
    public class ReasonCode
    {
        [Key]
        public int ReasonCodeId { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
