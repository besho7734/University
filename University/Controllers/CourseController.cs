using Microsoft.AspNetCore.Mvc;
using University.Data;
using University.Models;

namespace University.Controllers
{
    public class CourseController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CourseController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Course course)
        {
            _db.courses.Add(course);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
            Course course = _db.courses.FirstOrDefault(X=> X.CourseID == id);
            return View(course);
        }
        [HttpPost]
        public IActionResult Update(Course course)
        {
            Course temp = _db.courses.FirstOrDefault(x=>x.CourseID == course.CourseID);
            temp.CourseName=course.CourseName;
            temp.ProfessorID=course.ProfessorID;
            _db.courses.Update(temp);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            Course course= _db.courses.FirstOrDefault(y=>y.CourseID==id);
            _db.courses.Remove(course);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
