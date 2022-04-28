using App.Data;
using App.Models;
using App.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
	public class AdminController : Controller
	{
		private readonly IRepository<Admin> _adminRepository;
		public AdminController(IRepository<Admin> adminRepository)
		{
			_adminRepository = adminRepository;
		}
		// GET: Admin
		public ActionResult Index()
		{
			return View("Index");
		}
		// POST: Admin
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Index(LoginRequest login)
		{
			if (ModelState.IsValid)
			{
				var admin = _adminRepository.GetAll().Find(a => a.Email == login.Email);
				if (admin != null && BCrypt.Net.BCrypt.Verify(login.Password, admin.Password))
				{
					HttpContext.Session.SetString("Name", admin.Username);
					HttpContext.Session.SetInt32("Id", admin.Id);
					HttpContext.Session.SetString("Admin", "true");
					Console.WriteLine("Admin Successful");
					return RedirectToAction("Index", "Home");
				}
				else
				{
					ModelState.AddModelError("", "Invalid Admin");
				}
			}
			return View("Index");
		}
	}
}