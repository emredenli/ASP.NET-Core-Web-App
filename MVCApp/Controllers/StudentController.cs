using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;
using MVCApp.Services;

namespace MVCApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentServices _studentServices;

        public StudentController(IStudentServices studentServices)
        {
            _studentServices = studentServices;
        }
        public IActionResult Index()
        {
            List<Student> list = _studentServices.GetAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult CreateStudent(Student student)
        {
            int i = _studentServices.Create(student);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Student student = _studentServices.Get(id);
            return View(student);
        }

        public IActionResult Update(Student student)
        {
            _studentServices.Update(student);
            return RedirectToAction("Details", new { id = student.StudentId});

        }
        public IActionResult Details(int id)
        {
            Student student = _studentServices.Get(id);
            return View(student);
        }

        public IActionResult Delete(int id)
        {
            bool x = _studentServices.Delete(id);
            if (x != true)
                Console.WriteLine("hata");

            return RedirectToAction("Index");
        }
    }
}
