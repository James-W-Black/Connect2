using System.ComponentModel.DataAnnotations;

namespace ConnectWeb.Models
{
    public class UserType
    {
        [Key]
        public int userTypeId { get; set; }
        [Required]
        public string userTypeName { get; set; }

        
    }
}
