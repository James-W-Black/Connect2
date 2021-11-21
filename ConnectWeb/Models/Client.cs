using System.ComponentModel.DataAnnotations;

namespace ConnectWeb.Models
{
    public class Client
    {
        [Key]
        public int clientId { get; set; }
        [Required]
        public string clientName { get; set; }

        

    }
}
