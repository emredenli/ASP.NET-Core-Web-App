using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;
using MVCApp.Services;

namespace MVCApp.Controllers
{
    public class SubjectController : Controller
    {

        private readonly ISubjectServices _subjectServices;
        private readonly IMailService _mailService;

        private readonly ILogger<SubjectController> _logger;

        public SubjectController(ISubjectServices subjectServices, ILogger<SubjectController> logger, IMailService mailService)
        {
            _subjectServices = subjectServices;
            _logger = logger;
            _mailService = mailService;
        }

        public IActionResult Index()
        {
            _mailService.Send("", "", "");

            List<Subject> list = _subjectServices.GetAll();

            return View(list);
        }

        //public class SubjectAndTeacherViewModel
        //{
        //    public List<Subject> subjectList { get; set; }
        //    public Teacher tecat { get; set; }
        //}

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult CreateSubject(Subject subject)
        {
            int i = _subjectServices.Create(subject);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Subject subject = _subjectServices.Get(id);

            return View(subject);
        }

        public IActionResult Update(Subject sb)
        {
            _subjectServices.Update(sb);
            return RedirectToAction("Details", new { id = sb.SubjectId });
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Subject subject = _subjectServices.Get(id);

            return View(subject);
        }

        public IActionResult Delete(int id)
        {
            bool x = _subjectServices.Delete(id);
            if (x != true)
                Console.WriteLine("Hata");

            return RedirectToAction("Index");


        }
    }
}
