using System.ComponentModel.DataAnnotations;

namespace App.ViewModels
{
    public class CreateProfileRequest
    {
        [Required]
        [MaxLength(30)]
        [MinLength(2)]
        public string? ProfileFirstName { get; set; }

        [Required]
        [MaxLength(30)]
        [MinLength(2)]
        public string? ProfileLastName { get; set; }

        [Required]
        public string? ProfileEmail { get; set; }

        [Required]
        [MaxLength(15)]
        [MinLength(8)] // 1 majuscule 1 min but jsp comment faire
        public string? ProfilePassword { get; set; }

        [Required]
        [DataType(DataType.DateTime)] // < 16 ans
        public DateTime ProfileBirthDate { get; set; }
    }
}