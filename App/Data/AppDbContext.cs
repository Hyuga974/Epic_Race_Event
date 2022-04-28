using App.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Data;
public class AppDbContext : DbContext
{
	public DbSet<Race>? Races { get; set; }
	public DbSet<RaceResult>? RaceResults { get; set; }
	public DbSet<ResultItem>? ResultItem { get; set; }
	public DbSet<Profile>? Profiles { get; set; }
	public DbSet<Category>? Categories { get; set; }
	public DbSet<Vehicule>? Vehicules { get; set; }
	public DbSet<Admin>? Admins { get; set; }
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
	}
}