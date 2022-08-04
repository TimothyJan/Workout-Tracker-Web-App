﻿using Microsoft.AspNetCore.Mvc;
using WorkoutTrackerWeb.Data;
using WorkoutTrackerWeb.Models;

namespace WorkoutTrackerWeb.Controllers
{
    public class WorkoutController : Controller
    {
        private readonly ApplicationDbContext _db;
        public WorkoutController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Workout> objWorkoutList = _db.Workouts;
            return View(objWorkoutList);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Workout obj)
        {
            if(ModelState.IsValid)
            {
                _db.Workouts.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
