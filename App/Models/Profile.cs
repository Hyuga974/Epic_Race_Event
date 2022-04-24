using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public DateTime BirthDate { get; set; }
    }
}