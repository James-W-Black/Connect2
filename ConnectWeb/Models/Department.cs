using System.ComponentModel.DataAnnotations;

namespace ConnectWeb.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required]
        public string DepartmentName { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
