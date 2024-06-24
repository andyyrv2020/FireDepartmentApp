namespace FireDepartmentManagerWebApp.ViewModels
{
    public class VehicleStatsViewModel
    {
        public string VehicleName { get; set; }
        public double? AverageDuration { get; set; }
        public double? MinDuration { get; set; }
        public double? MaxDuration { get; set; }
        public int IncidentCount { get; set; }
        public double? TotalHours { get; set; }
    }
}
