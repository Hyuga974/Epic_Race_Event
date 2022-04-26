using System.ComponentModel.DataAnnotations;
using App.Models;

namespace App.ViewModels
{
    public class CreateRaceRequest
    {
        [Required(ErrorMessage = "Vous devez renseigner un nom à votre course")]
        [MaxLength(10)]
        public string? Name { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }
        public string? StartHour { get; set; }
        public int? Latitude { get; set; }
        public int? Longitude { get; set; }
        public int LimitDrivers { get; set; }
        public List<Driver>? DriversList { get; set; }
        public string? Img { get; set; }
        public int LimitAge { get; set; }
        public string? Result { get; set; }
        public string? CatVehicle { get; set; } //A changer pour un enum des vehicles
    }
}