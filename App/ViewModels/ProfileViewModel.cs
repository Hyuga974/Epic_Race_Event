namespace App.ViewModels
{
	public class ProfileViewModel
	{
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public string? Email { get; set; }
		public DateTime BirthDate { get; set; }
		public ProfileViewModel(string FName, string LName, string email, DateTime Birth)
		{
			FirstName = FName;
			LastName = LName;
			Email = email;
			BirthDate = Birth;
		}
	}
}