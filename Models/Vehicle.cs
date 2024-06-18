using System.ComponentModel.DataAnnotations;

namespace FireDepartmentManagerWebApp.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Vehicle")]
        public string? CarModel { get; set; }

        [Display(Name = "Monday")]
        public bool IsMonday { get; set; }

        [Display(Name = "Tuesday")]
        public bool IsTuesday { get; set; }

        [Display(Name = "Wednesday")]
        public bool IsWednesday { get; set; }

        [Display(Name = "Thursday")]
        public bool IsThursday { get; set; }

        [Display(Name = "Friday")]
        public bool IsFriday { get; set; }

        [Display(Name = "Saturday")]
        public bool IsSaturday { get; set; }

        [Display(Name = "Sunday")]
        public bool isSunday { get; set; }

        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
        public virtual ICollection<Incident> Incidents { get; set; } = new List<Incident>();
    }
}
