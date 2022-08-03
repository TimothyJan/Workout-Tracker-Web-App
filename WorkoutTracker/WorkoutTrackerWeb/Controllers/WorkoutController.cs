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
    }
}
