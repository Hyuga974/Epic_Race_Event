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
                    FirstName="Tamashi",
                    LastName="Yami"
                },
                new Driver()
                {
                    Id = 2,
                    FirstName="Toto",
                    LastName="Ynov"
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
            return View("CreateDriver");
        }

        // POST: Drivers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, Driver newDriver)
        {
            try
            {
                // TODO: Add insert logic here
                Console.WriteLine("Creating");
                if (ModelState.IsValid && DateTime.Compare(newDriver.BirthDate, new DateTime(DateTime.Now.Year - 18, DateTime.Now.Month, DateTime.Now.Day))<=0)
                {
                    // TODO: Add insert logic here

                    Console.WriteLine(newDriver.Id);
                    Console.WriteLine(newDriver.FirstName);
                    Console.WriteLine(newDriver.LastName);
                    Console.WriteLine(newDriver.BirthDate);

                    Console.WriteLine(newDriver.Email);

                    //_dbContext.Races.Add(newRace);
                    //_dbContext.SaveChanges();

                    return RedirectToAction(nameof(Index));
                }
                return View("CreateDriver");
            }
            catch
            {
                return View("CreateDriver");
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