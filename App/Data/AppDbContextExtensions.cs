using App.Models;

namespace App.Data;
public static class AppDbContextExtensions
{
	public static void Seed(this AppDbContext dbContext)
	{
		if (!dbContext.Categories.Any() || !dbContext.Vehicules.Any() || !dbContext.Admins.Any())
		{
			var categories = new List<Category>()
				{
					new Category()
					{
						Name = "Super Car",
						Description = "",
						Img = "",
						Color = ""
					},
					new Category()
					{
						Name = "Italian Classic",
						Description = "",
						Img = "",
						Color = ""
					},
					new Category()
					{
						Name = "American Legend",
						Description = "",
						Img = "",
						Color = ""
					},
					new Category()
					{
						Name = "Hyper Car",
						Description = "",
						Img = "",
						Color = ""
					},
					new Category()
					{
						Name = "Japan Race Car",
						Description = "",
						Img = "",
						Color = ""
					},
					new Category()
					{
						Name = "Sport car",
						Description = "",
						Img = "",
						Color = ""
					},
					new Category()
					{
						Name = "German Classics",
						Description = "",
						Img = "",
						Color = ""
					},
					new Category()
					{
						Name = "High Performance",
						Description = "",
						Img = "",
						Color = ""
					},
					new Category()
					{
						Name = "Muscle Car",
						Description = "",
						Img = "",
						Color = ""
					}
				};
			var vehicules = new List<Vehicule>()
			{
				new Vehicule()
				{
					Brand = "Ferrari",
					Model = "F40",
					DateConstruct = 1987,
					Power = 7,
					Img = "",
					Categories = new List<Category>()
					{
						categories[0],
						categories[1]
					}
				},
				new Vehicule()
				{
					Brand = "Lamborghini",
					Model = "Huracan",
					DateConstruct = 2014,
					Power = 7,
					Img = "",
					Categories = new List<Category>()
					{
						categories[0]
					}
				},
				new Vehicule()
				{
					Brand = "Ford",
					Model = "Mustang",
					DateConstruct = 1969,
					Power = 3,
					Img = "",
					Categories = new List<Category>()
					{
						categories[2],
						categories[8]
					}
				},
				new Vehicule()
				{
					Brand = "Dodge",
					Model = "Charger R/T",
					DateConstruct = 2021,
					Power = 5,
					Img = "",
					Categories = new List<Category>()
					{
						categories[8]
					}
				},
				new Vehicule()
				{
					Brand = "Pagani",
					Model = "Huayra R",
					DateConstruct = 2018,
					Power = 9,
					Img = "",
					Categories = new List<Category>()
					{
						categories[3]
					}
				},
				new Vehicule()
				{
					Brand = "Bugatti",
					Model = "Chiron",
					DateConstruct = 2019,
					Power = 10,
					Img = "",
					Categories = new List<Category>()
					{
						categories[4]
					}
				},
				new Vehicule()
				{
					Brand = "Toyota",
					Model = "Supra Yakuza Edition",
					DateConstruct = 1995,
					Power = 7,
					Img = "",
					Categories = new List<Category>()
					{
						categories[5]
					}
				},
				new Vehicule()
				{
					Brand = "Honda",
					Model = "S2000 Racing",
					DateConstruct = 2009,
					Power = 6,
					Img = "",
					Categories = new List<Category>()
					{
						categories[4],
						categories[5]
					}
				},
				new Vehicule()
				{
					Brand = "BMW",
					Model = "E30",
					DateConstruct = 1991,
					Power = 6,
					Img = "",
					Categories = new List<Category>()
					{
						categories[5],
						categories[6]
					}
				},
				new Vehicule()
				{
					Brand = "Porshe",
					Model = "911 GT3",
					DateConstruct = 2007,
					Power = 7,
					Img = "",
					Categories = new List<Category>()
					{
						categories[5],
						categories[6],
						categories[7]
					}
				}
			};

			if (!dbContext.Categories.Any())
			{
				dbContext.Categories.AddRange(categories);
				dbContext.SaveChanges();
			}
			if (!dbContext.Vehicules.Any())
			{
				dbContext.Vehicules.AddRange(vehicules);
				dbContext.SaveChanges();
			}
			if (!dbContext.Admins.Any())
			{
				var admins = new List<Admin>()
				{
					new Admin()
					{
						Username = "Sandra",
						Email = "sandra.heraud@ynov.com",
						Password = BCrypt.Net.BCrypt.HashPassword("Sandra_Access")
					},
					new Admin()
					{
						Username = "Costa",
						Email = "costa.reype@ynov.com",
						Password = BCrypt.Net.BCrypt.HashPassword("Costa_Access")
					},
					new Admin()
					{
						Username = "Mattéo",
						Email = "matteo.ferreirasilva@ynov.com",
						Password = BCrypt.Net.BCrypt.HashPassword("Mattéo_Access")
					},
					new Admin()
					{
						Username = "Maxime",
						Email = "maxime.mourgues@ynov.com",
						Password = BCrypt.Net.BCrypt.HashPassword("Maxime_Access")
					},
				};
				dbContext.Admins.AddRange(admins);
				dbContext.SaveChanges();
			}
		}
	}
}