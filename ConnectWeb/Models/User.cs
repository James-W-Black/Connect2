using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConnectWeb.Models
{
    public class User
    {
        [Key]
        public int userId { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }

        [Required]       
        public int clientId { get; set; }
        [Required]       
        public int userTypeId { get; set; }

        public UserType UserType { get; set; }

        public Client Client { get; set; }
    }
}
