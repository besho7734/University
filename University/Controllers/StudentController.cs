using Microsoft.AspNetCore.Mvc;
using University.Data;
using University.Models;

namespace University.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _db;
        public StudentController(ApplicationDbContext db)
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
        public IActionResult Create(Student student)
        {
            _db.students.Add(student);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
            Student student = _db.students.SingleOrDefault(x => x.StudentID == id);
            return View(student);
        }
        [HttpPost]
        public IActionResult Update(Student student)
        {
            Student temp = _db.students.SingleOrDefault(x=>x.StudentID == student.StudentID);
            temp.FirstName = student.FirstName;
            temp.LastName = student.LastName;
            temp.Email = student.Email;
            temp.Major = student.Major;
            _db.students.Update(temp);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            Student student= _db.students.SingleOrDefault(y => y.StudentID == id);
            _db.students.Remove(student);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult AssignCourse()
        {
            return View();
        }
    }
}
