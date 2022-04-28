using App.Models;

namespace App.Data
{
	public class EFProfileRepository : IRepository<Profile>
	{
		private readonly AppDbContext _dbContext;
		public EFProfileRepository(AppDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		public Profile Add(Profile model)
		{
			return _dbContext.Profiles.Add(model).Entity;
		}
		public int Commit()
		{
			return _dbContext.SaveChanges();
		}
		public List<Profile> GetAll()
		{
			return _dbContext.Profiles.ToList();
		}
		public Profile GetById(int id)
		{
			return _dbContext.Profiles.Single(r => r.Id == id);
		}
	}
}