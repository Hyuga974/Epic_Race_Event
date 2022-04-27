using System.ComponentModel.DataAnnotations;

namespace App.ViewModels
{
	public class LoginRequest
	{
		[Required]
		public string Email { get; set; }
		[Required]
		public string Password { get; set; }
	}
}