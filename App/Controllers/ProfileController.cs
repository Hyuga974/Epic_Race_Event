using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data;
using App.Models;
using App.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IRepository<Profile> _profileRepository;

        public ProfileController(IRepository<Profile> profileRepository)
        {
            _profileRepository = profileRepository;
        }
        // GET: Profile
        public ActionResult Index()
        {
            return View("Index");
        }

        // GET: Profile/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Profile/Create
       public ActionResult Create()
        {
            return View("CreateProfile");
        }

        // POST: Profile/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateProfileRequest profile)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // TODO: Add insert logic here
                    Profile newProfile = new()
                    {
                        FirstName = profile.FirstName,
                        LastName = profile.LastName,
                        Email = profile.Email,
                        Password = profile.Password,
                        BirthDate = profile.BirthDate,
                    };
                    _profileRepository.Add(newProfile);
                    _profileRepository.Commit();

                    HttpContext.Session.SetString("Name", newProfile.FirstName);
                    HttpContext.Session.SetInt32("Id", newProfile.Id);

                    return RedirectToAction(nameof(Index));
                }

                return View("CreateProfile");
            }
            catch
            {
                return View("CreateProfile");
            }
        }

        // GET: Profile/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Profile/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Profile/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Profile/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}