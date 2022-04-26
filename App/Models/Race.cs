
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Race
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string EventDate { get; set;}
        public string StartHour { get; set; }
        public int? Latitude { get; set; }
        public int? Longitude { get; set; }
        public int LimitDrivers { get; set; }
        public int NbDrivers { get; set; }
        public List<Driver> DriversList { get; set; }
        public string? Img { get; set; }
        public int LimitAge { get; set; }
        public string? Result { get; set; }
        public string? CatVehicle { get; set; } //A changer pour un enum des vehicles

        public Race(int id, string name, DateTime date, int nbDrivers, int age){
            DriversList = new List<Driver>();

            Id = id;
            Name = name;
            Date = date;
            EventDate = date.ToString("d");
            StartHour = date.ToString("H:mm:ss");
            LimitDrivers = nbDrivers;
            NbDrivers = DriversList.Count;
            LimitAge = age;
        }
    }
}