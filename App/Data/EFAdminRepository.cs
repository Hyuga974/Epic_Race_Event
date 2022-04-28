using App.Models;

namespace App.Data
{
	public class EFAdminRepository : IRepository<Admin>
	{
		private readonly AppDbContext _dbContext;
		public EFAdminRepository(AppDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		public Admin Add(Admin model)
		{
			return _dbContext.Admins.Add(model).Entity;
		}
		public int Commit()
		{
			return _dbContext.SaveChanges();
		}
		public List<Admin> GetAll()
		{
			return _dbContext.Admins.ToList();
		}
		public Admin GetById(int id)
		{
			return _dbContext.Admins.Single(r => r.Id == id);
		}
	}
}