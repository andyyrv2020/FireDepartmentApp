using Microsoft.AspNetCore.Mvc;
using FireDepartmentManagerWebApp.Data;
using FireDepartmentManagerWebApp.ViewModels;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FireDepartmentManagerWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            //Task 1: Vehicle on Duty Today
            var today = DateTime.Today.DayOfWeek;
            var vehiclesOnDuty = _context.Vehicles.Where(v =>
                (today == DayOfWeek.Monday && v.IsMonday) ||
                (today == DayOfWeek.Tuesday && v.IsTuesday) ||
                (today == DayOfWeek.Wednesday && v.IsWednesday) ||
                (today == DayOfWeek.Thursday && v.IsThursday) ||
                (today == DayOfWeek.Friday && v.IsFriday) ||
                (today == DayOfWeek.Saturday && v.IsSaturday) ||
                (today == DayOfWeek.Sunday && v.isSunday)
            ).ToList();

            ViewBag.VehiclesOnDuty = vehiclesOnDuty;

            // Task 2: Employee Rankings by Number of Incidents
            var employeeRankings = _context.Employees
                .Select(e => new EmployeeRankingViewModel
                {
                    EmployeeName = e.FirstName,
                    IncidentCount = e.Incidents.Count()
                })
                .OrderByDescending(e => e.IncidentCount)
                .ToList();

            ViewBag.EmployeeRankings = employeeRankings;

            // Task 3: Vehicle Incident Statistics
            var vehicleStats = _context.Vehicles
                .Select(v => new VehicleStatsViewModel
                {
                    VehicleName = v.CarModel,
                    AverageDuration = v.Incidents.Any() ? v.Incidents.Average(i => (double?)EF.Functions.DateDiffHour(i.IncidentStart, i.IncidentEnd)) : null,
                    MinDuration = v.Incidents.Any() ? v.Incidents.Min(i => (double?)EF.Functions.DateDiffHour(i.IncidentStart, i.IncidentEnd)) : null,
                    MaxDuration = v.Incidents.Any() ? v.Incidents.Max(i => (double?)EF.Functions.DateDiffHour(i.IncidentStart, i.IncidentEnd)) : null,
                    IncidentCount = v.Incidents.Count(),
                    TotalHours = v.Incidents.Sum(i => (double?)EF.Functions.DateDiffHour(i.IncidentStart, i.IncidentEnd))
                })
                .ToList();

            ViewBag.VehicleStats = vehicleStats;

            // Task 4: Annual Efficiency for Fire Extinguishing for Each Vehicle
            var vehicleEfficiency = _context.Vehicles
                .Select(v => new VehicleEfficiencyViewModel
                {
                    VehicleName = v.CarModel,
                    Efficiency = v.Incidents.Any() ? v.Incidents.Sum(i => i.WaterUsed) / (double?)v.Incidents.Count() : null
                })
                .OrderByDescending(v => v.Efficiency)
                .ThenBy(v => v.VehicleName)
                .ToList();

            ViewBag.VehicleEfficiency = vehicleEfficiency;

            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
