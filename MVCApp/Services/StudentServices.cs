using MVCApp.Context;
using MVCApp.Models;

namespace MVCApp.Services
{
    public class StudentServices : IStudentServices
    {
        private MVCContext _db;

        public StudentServices(MVCContext db)
        {
            _db = db;
        }
        public int Create(Student student)
        {
            _db.Students.Add(student);
            _db.SaveChanges();
            return student.StudentId;
        }

        public bool Delete(int id)
        {
            try
            {
                Student student = Get(id);
                _db.Students.Remove(student);
                _db.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public Student Get(int id)
        {
            Student student = _db.Students.FirstOrDefault(x => x.StudentId == id);
            return student;
        }

        public List<Student> GetAll()
        {
            List<Student> list = _db.Students.Select(x => x).ToList();
            return list;
        }

        public void Update(Student student)
        {
            _db.Students.Update(student);
            _db.SaveChanges();
        }
    }
}
