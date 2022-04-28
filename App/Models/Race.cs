
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
	public class Race
	{
		public int Id { get; set; }
		[Required]
		public string? Name { get; set; }
		public DateTime Date { get; set; }
		public string? StartHour { get; set; }
		public int? Latitude { get; set; }
		public int? Longitude { get; set; }
		public int LimitDrivers { get; set; }
		public List<Profile>? DriversList { get; set; }
		public string? Img { get; set; }
		public int LimitAge { get; set; }
		public string? Result { get; set; }
		public List<Category>? CatVehicle { get; set; } // A changer pour un enum des vehicles

		/*
- Un identifiant
- Un nom (length: min 2, max 50 (requis) 
- Une date d'événement (requis) 
- Une heure de départ de course (requis) 
- Une latitude (lieu de rassemblement) (requis)
- Une longitude (lieu de rassemblement) (requis)
- Un nombre max de participants (15 par défaut)
- Une image (url vers une image de course)
- Des pilotes qui participent à la course (vide par défaut)
- Une restriction d’âge (+21 ans par défaut)
- Un résultat (si la course a eu lieu)
- Des catégories de véhicules autorisés (requis) - ne doit pas être vide !
		*/
	}
}