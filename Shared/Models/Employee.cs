using System.ComponentModel.DataAnnotations;

namespace MyEmployees.Server.Models
{
    public class Employee
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string firstname { get; set; }

        [Required]
        [StringLength(50)]
        public string lastname { get; set; }

        [Required]
        [StringLength(50)]
        public string jobrole { get; set; }

        [Required]
        [StringLength(50)]
        public string department { get; set; }
    }
}
