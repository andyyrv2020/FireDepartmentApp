using FireDepartmentManagerWebApp.Data;
using FireDepartmentManagerWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

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

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
