
namespace App.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name {get; set;}
        public string? Description {get;set;}
        public string? Img {get;set;}
        public string? Color {get;set;}

        /*
	Une catégorie de véhicule
Un identifiant 
Un nom
Une description
Une image (url)
Une couleur (code hexadécimal)

        */
    }
}