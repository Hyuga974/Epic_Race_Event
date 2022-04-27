using System.ComponentModel.DataAnnotations;

namespace App.ViewModels
{
    public class CreateProfileRequest
    {
        [Required]
        [MaxLength(30)]
        [MinLength(2)]
        public string? FirstName { get; set; }

        [Required]
        [MaxLength(30)]
        [MinLength(2)]
        public string? LastName { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        [MaxLength(15)]
        [MinLength(8)] // 1 majuscule 1 min but jsp comment faire
        public string? Password { get; set; }

        [Required]
        [DataType(DataType.DateTime)] // < 16 ans
        public DateTime BirthDate { get; set; }
    }
}