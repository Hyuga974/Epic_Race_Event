using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using App.Models;
using App.Data;
using App.ViewModels;

namespace App.Controllers
{
	public class DriverController : Controller
	{
		private readonly IRepository<Profile> _profileRepository;
		public DriverController(IRepository<Profile> profileRepository)
		{
			_profileRepository = profileRepository;
		}
		// GET: Driver
		public ActionResult Index()
		{
			if (HttpContext.Session.GetString("Admin") == null)
			{
				return RedirectToAction("Index", "Admin");
			}
			var drivers = new List<DriversViewModel>();
			var alldrivers = _profileRepository.GetAll();
			for (int i = 0; i < alldrivers.Count; i++)
			{
				drivers.Add(new DriversViewModel()
				{
					Id = alldrivers[i].Id,
					FirstName = alldrivers[i].FirstName,
					LastName = alldrivers[i].LastName,
				});
			}
			return View("Index", drivers);
		}

		// GET: Driver/Details/5
		public ActionResult Details(int id)
		{
			if (HttpContext.Session.GetString("Admin") == null)
			{
				return RedirectToAction("Index", "Admin");
			}
			return View("Detail", _profileRepository.GetById(id));
		}
	}
}