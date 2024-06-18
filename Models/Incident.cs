using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FireDepartmentManagerWebApp.Models
{
    public class Incident
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Incident Type")]
        public string Type { get; set; }

        [Display(Name = "Used Water (L)")]
        public double WaterUsed { get; set; }

        [Required]
        [Display(Name = "Incident Start")]
        public DateTime IncidentStart { get; set; }
        [Display(Name = "Incident End")]
        public DateTime IncidentEnd { get; set; }

        public int? VehicleId { get; set; }
        [ForeignKey("VehicleId")]
        public virtual Vehicle? Vehicle { get; set; }

        public int? EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Employee? Employee { get; set; }
    }
}
