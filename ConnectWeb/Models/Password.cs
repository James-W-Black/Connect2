using System.ComponentModel.DataAnnotations;

namespace ConnectWeb.Models
{
    public class Password
    {
        [Key]
        public int PasswordId { get; set; }
        [Required]
        public string HashedPassword { get; set; }
        [Required]
        public int userId { get; set; }
        public User User { get; set; }
    }
}
