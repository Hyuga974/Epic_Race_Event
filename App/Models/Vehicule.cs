using System.ComponentModel.DataAnnotations;
namespace App.Models
{
	public class Vehicule
	{
		public int Id { get; set; }
		public List<Category>? Categories { get; set; }
		public int? DateConstruct { get; set; }
		public string? Brand { get; set; }
		public string? Model { get; set; }
		public int Power { get; set; }
		public List<Profile>? Drivers { get; set; }
		public string? Img { get; set; }
	}
}