using Microsoft.AspNetCore.Mvc;
using AHMITMTR.Data;
using AHMITMTR.Models;
using System.Linq;

namespace AHMITMTR.Controllers
{
    public class MotorController : Controller
    {
        private readonly AppDbContext _context;

        public MotorController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var dataMotor = _context.AHMITMTR_MSTMOTOR.ToList();
            return View(dataMotor);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Motor motor)
        {
            if (ModelState.IsValid)
            {
                _context.AHMITMTR_MSTMOTOR.Add(motor);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(motor);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0) return NotFound();

            var motor = _context.AHMITMTR_MSTMOTOR.Find(id);
            if (motor == null) return NotFound();

            return View(motor);
        }

        [HttpPost]
        public IActionResult Edit(Motor motor)
        {
            if (ModelState.IsValid)
            {
                _context.AHMITMTR_MSTMOTOR.Update(motor);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(motor);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            
            var motor = _context.AHMITMTR_MSTMOTOR.Find(id);
            if (motor == null)
            {
                return NotFound();
            }

            return View(motor);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var motor = _context.AHMITMTR_MSTMOTOR.Find(id);
            if (motor == null)
            {
                return NotFound();
            }

            _context.AHMITMTR_MSTMOTOR.Remove(motor);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}