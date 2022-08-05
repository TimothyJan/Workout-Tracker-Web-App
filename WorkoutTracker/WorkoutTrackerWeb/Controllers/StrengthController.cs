using Microsoft.AspNetCore.Mvc;
using WorkoutTrackerWeb.Data;
using WorkoutTrackerWeb.Models;

namespace WorkoutTrackerWeb.Controllers
{
    public class StrengthController : Controller
    {
        private readonly ApplicationDbContext _db;
        public StrengthController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Strength> objStrengthList = _db.Strengths;
            return View(objStrengthList);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Strength obj)
        {
            if(ModelState.IsValid)
            {
                _db.Strengths.Add(obj);
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
            var strengthFromDb = _db.Strengths.Find(id);

            if (strengthFromDb == null)
            {
                return NotFound();
            }

            return View(strengthFromDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Strength obj)
        {
            /*
            if(obj.StrengthId == 0)
            {
                return RedirectToAction("Index");
            }
            */
            if (ModelState.IsValid)
            {
                _db.Strengths.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Workout updated successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
