using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Driver
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a name between 2 and 30 characters with an upper case letter at the beginning.")]
        [MinLength(2), MaxLength(30), RegularExpression(@"^[A-Z]+[a-zA-Z\s-]*$", ErrorMessage= "Firstname must be between 2 and 30 characters and begin wih upper case letter")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "Please enter a name between 2 and 30 characters.")]
        [MinLength(2), MaxLength(30), RegularExpression(@"^[A-Z]+[a-zA-Z\s-]*$",  ErrorMessage= "Lastname must be between 2 and 30 characters and begin wih upper case letter")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Please enter a pass between 8 and 15 characters.")]
        [MinLength(8, ErrorMessage= "Password must be between 8 and 15 characters."), MaxLength(15, ErrorMessage= "Password must be between 8 and 15 characters."), RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).*$", ErrorMessage= "Password must contains 1 Upepr case, 1 lowercase, 1 number.")]        
        public string? Password { get; set; }
        public string? Email { get; set; }

        [Required()]
        public DateTime BirthDate { get; set; }    

    }


} 