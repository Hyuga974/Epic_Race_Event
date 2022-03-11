using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Race
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateOnly EventDate { get; set; }
        public int StartHour { get; set; }
        public int? Latitude { get; set; }
        public int? Longitude { get; set; }
        public int NbDrivers { get; set; }
        public string? Img { get; set; }
        public Driver[] Drivers { get; set; }
        public int LimitAge { get; set;}
        public string? Result { get; set; }
        public string? CatVehicle { get; set; } //A changer pour un enum des vehicles

    }
}