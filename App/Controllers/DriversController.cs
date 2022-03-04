using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using App.Models;

namespace App.Controllers
{
    public class DriversController : Controller
    {
        // GET: Drivers
        public ActionResult Index()
        {
            var drivers = new List<Driver>()
            {
                new Driver()
                {
                    Id = 1,
                    firstName="Tamashi",
                    lastName="Yami"
                },
                new Driver()
                {
                    Id = 2,
                    firstName="Toto",
                    lastName="Ynov"
                },
            };
            return View(drivers);
        }

        // GET: Drivers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Drivers/Create
        public ActionResult Create()
        {
            return View("CreateDrivers");
        }

        // POST: Drivers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Drivers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Drivers/Edit/5
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

        // GET: Drivers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Drivers/Delete/5
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