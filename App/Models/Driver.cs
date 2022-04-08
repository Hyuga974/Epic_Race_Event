using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Driver
    {
        
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Please enter a name between 2 and 30 characters.")]
        [MinLength(2), MaxLength(30), RegularExpression(@"^[A-Z]+[a-zA-Z\s-]*$")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "Please enter a name between 2 and 30 characters.")]
        [MinLength(2), MaxLength(30), RegularExpression(@"^[A-Z]+[a-zA-Z\s-]*$")]
        public string? LastName { get; set; }
        [MinLength(8), MaxLength(15), RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).*$")]        
        public string? Password { get; set; }
        public string? Email { get; set; }
        public DateOnly BirthDate { get; set; }
    }
}