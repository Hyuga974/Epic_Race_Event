using App.Data;
using App.Models;
using App.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace App.controller
{
	public class LoginController : Controller
	{
		private readonly IRepository<Profile> _profileRepository;
		public LoginController(IRepository<Profile> profileRepository)
		{
			_profileRepository = profileRepository;
		}
		// GET: Login
		public ActionResult Index()
		{
			return View("Index");
		}
		// POST: Login
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Index(LoginRequest login)
		{
			if (ModelState.IsValid)
			{
				var profile = _profileRepository.GetAll().Find(p => p.Email == login.Email);
				if (profile != null && BCrypt.Net.BCrypt.Verify(login.Password, profile.Password))
				{
					HttpContext.Session.SetString("Name", profile.FirstName);
					HttpContext.Session.SetInt32("Id", profile.Id);
					Console.WriteLine("Login Successful");
					return RedirectToAction("Index", "Home");
				}
				else
				{
					ModelState.AddModelError("", "Invalid login");
				}
			}
			return View("Index");
		}
	}
}
