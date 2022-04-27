using System.ComponentModel.DataAnnotations;

namespace App.ViewModels
{
	public class Session
	{
		[Required]
		public string Name { get; set; }
	}
}