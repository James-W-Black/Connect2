using System.ComponentModel.DataAnnotations;

namespace ConnectWeb.Models
{
    public class ClientLocation
    {
        [Key]
        public int ClientLocationId { get; set; }
        [Required]
        public int ClientId { get; set; }
        public Client Client { get; set; }
        [Required]
        public string ClientLocationName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Postcode { get; set; }
    }
}
