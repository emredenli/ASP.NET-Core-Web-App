using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;
using MVCApp.Services;

namespace MVCApp.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherServices _teacherServices;

        public TeacherController(ITeacherServices teacherServices)
        {
            _teacherServices = teacherServices;
        }

        public IActionResult Index()
        {
            List<Teacher> list = _teacherServices.GetAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult CreateTeacher(Teacher teacher)
        {
            int i = _teacherServices.Create(teacher);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Teacher teacher = _teacherServices.Get(id);
            return View(teacher);
        }

        public IActionResult Update(Teacher teacher)
        {
            _teacherServices.Update(teacher);
            return RedirectToAction("Details", new { id  = teacher.TeacherId});
        }

        public IActionResult Details(int id)
        {
            Teacher teacher = _teacherServices.Get(id);
            return View(teacher);
        }

        public IActionResult Delete(int id)
        {
            bool x = _teacherServices.Delete(id);

            if (x != true)
                Console.WriteLine("Hata");
            
            return RedirectToAction("Index");
        }
    }
}
