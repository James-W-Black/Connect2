using System.ComponentModel.DataAnnotations;

namespace ConnectWeb.Models
{
    public class RateType
    {
        [Key]
        public int RateTypeId { get; set; }
        [Required]
        public string RateName { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public decimal ChareRate { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
