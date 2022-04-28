using System.ComponentModel.DataAnnotations;

namespace App.ViewModels
{
	public class EditProfilRequest
	{
		[Required]
		[MaxLength(30)]
		[MinLength(2)]
		public string? FirstName { get; set; }

		[Required]
		[MaxLength(30)]
		[MinLength(2)]
		public string? LastName { get; set; }
	}
}