namespace App.Models
{
    public class Driver
    {
        public int Id { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public DateOnly BirthDate { get; set; }
    }
}