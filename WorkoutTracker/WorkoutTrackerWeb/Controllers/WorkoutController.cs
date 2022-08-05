using Microsoft.AspNetCore.Mvc;
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

        //GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var workoutFromDb = _db.Workouts.Find(id);

            if (workoutFromDb == null)
            {
                return NotFound();
            }

            return View(workoutFromDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Workout obj)
        {
            if (ModelState.IsValid)
            {
                _db.Workouts.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Workout updated successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
