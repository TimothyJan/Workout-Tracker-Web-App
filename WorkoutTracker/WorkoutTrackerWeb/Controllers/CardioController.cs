using Microsoft.AspNetCore.Mvc;
using WorkoutTrackerWeb.Data;
using WorkoutTrackerWeb.Models;

namespace WorkoutTrackerWeb.Controllers
{
    public class CardioController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CardioController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Cardio> objStrengthList = _db.Cardios;
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
        public IActionResult Create(Cardio obj)
        {
            if (ModelState.IsValid)
            {
                _db.Cardios.Add(obj);
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
            var cardioFromDb = _db.Cardios.Find(id);

            if (cardioFromDb == null)
            {
                return NotFound();
            }

            return View(cardioFromDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Cardio obj)
        {
            if (ModelState.IsValid)
            {
                _db.Cardios.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Workout updated successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
